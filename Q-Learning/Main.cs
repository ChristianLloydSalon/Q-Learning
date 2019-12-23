using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Resources;

namespace Q_Learning
{
    public partial class Main : Form
    {
        private Hashtable hashtable = new Hashtable();

        private bool agentExists = false;
        private bool cheeseExists = false;

        Node[,] nodes;
        private Node AgentNode = null;
        private Node CheeseNode = null;

        private Image mouseImage = Properties.Resources.mouse;
        private Image cheeseImage = Properties.Resources.cheese;
        private Image catImage = Properties.Resources.cat;
        private Image wallImage = Properties.Resources.wall;

        private float[,] Reward;
        private float[,] QTable;

        private List<Node> possibleStates = new List<Node>();


        // Q-LEARNING PARAMETERS
        private float EPSILON;
        private float EPSILON_DECAY_RATE;
        private float DISCOUNT;

        private int EPISODES;
        private int episode;
        private int STEPS;
        private int step;
        private int current_state;
         
        private Node currentState;
        private int  action;

        private Tuple<Node, int> NextState;

        private Random random = new Random();

        private bool trainingDone = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            gridSize.SelectedIndex = 0;

            InitializeGrid();
        }

        private void InitializeGrid()
        {
            hashtable.Clear();

            int gridWidth = 600;
            int gridHeight = 600;
            
            int size   = Int32.Parse(gridSize.SelectedItem.ToString());

            nodes = new Node[size, size];

            int height = gridWidth / size;
            int width  = gridHeight / size;

            int thickness = 5;  // node border thickness

            int count = 0;
            int y = 100;
            for(int i=0; i< size; i++)
            {
                int x = 20;
                for(int j=0; j< size; j++)
                {
                    count++;

                    NewPanel panel   = new NewPanel();
                    panel.Location   = new Point(x, y);
                    panel.BackColor  = Color.White;
                    panel.Size       = new Size(width, height);
                    panel.Name       = "panel" + count.ToString();
                    panel.PanelLabel = "0";
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    panel.MouseClick += Panel_MouseClick;
                    panel.BorderThickness = thickness;

                    this.Controls.Add(panel);

                    Node node = new Node(panel, i, j);
                    node.state = count;
                    nodes[i, j] = node;

                    hashtable.Add(count, node);

                    x += (width - thickness);
                }

                y += (height - thickness);
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                NewPanel panel = (NewPanel)sender;
                int number = Convert.ToInt32(Regex.Replace(panel.Name, "panel", string.Empty));

                Node node = (Node)hashtable[number];

                if (agentBtn.Checked)
                {
                    if (node.Agent)
                    {
                        node.panel.BackgroundImage = null;
                        node.Agent = false;
                        node.None = true;
                        agentExists = false;
                        AgentNode = null;

                        return;
                    }
                    else if (node.Wall)
                    {
                        throw new Exception("CANNOT PLACE AN AGENT ON THE WALL!");
                    }
                    else if(node.Cheese)
                    {
                        throw new Exception("CANNOT PLACE AN AGENT ON THE CHEESE!");
                    }
                    else if(agentExists)
                    {
                        AgentNode.panel.BackgroundImage = null;
                        AgentNode.Agent = false;
                        AgentNode.None = true;
                    }

                    node.panel.BackgroundImage = mouseImage;
                    node.Agent = true;
                    node.None = false;
                    AgentNode = node;
                    agentExists = true;
                }
                else if (cheeseBtn.Checked)
                {
                    if (node.Cheese)
                    {
                        node.panel.BackgroundImage = null;
                        node.Cheese = false;
                        node.None = true;
                        cheeseExists = false;
                        CheeseNode = null;

                        return;
                    }
                    else if (node.Wall)
                    {
                        throw new Exception("CANNOT PLACE A CHEESE ON THE WALL!");
                    }
                    else if (node.Agent)
                    {
                        throw new Exception("CANNOT PLACE A CHEESE ON THE AGENT!");
                    }
                    else if (cheeseExists)
                    {
                        CheeseNode.panel.BackgroundImage = null;
                        CheeseNode.Cheese = false;
                        CheeseNode.None = true;
                    }

                    node.panel.BackgroundImage = cheeseImage;
                    node.Cheese = true;
                    node.None = false;
                    CheeseNode = node;
                    cheeseExists = true;
                }
                else if(wallBtn.Checked)
                {
                    if(node.Wall)
                    {
                        node.panel.BackgroundImage = null;
                        node.Wall = false;
                        node.None = true;
                    }
                    else if(node.Cheese)
                    {
                        throw new Exception("CANNOT PLACE A WALL ON THE CHEESE!");
                    }
                    else if(node.Agent)
                    {
                        throw new Exception("CANNOT PLACE A WALL ON THE AGENT!");
                    }
                    else
                    {
                        node.Wall = true;
                        node.None = false;
                        node.panel.BackgroundImage = wallImage;
                    }
                }
                else if(catBtn.Checked)
                {
                    if (node.Cat)
                    {
                        node.panel.BackgroundImage = null;
                        node.Cat = false;
                        node.None = true;
                    }
                    else if (node.Cheese)
                    {
                        throw new Exception("CANNOT PLACE A CAT ON THE CHEESE!");
                    }
                    else if (node.Agent)
                    {
                        throw new Exception("CANNOT PLACE A CAT ON THE AGENT!");
                    }
                    else if (node.Wall)
                    {
                        throw new Exception("CANNOT PLACE A CAT ON THE WALL!");
                    }
                    else
                    {
                        node.Cat = true;
                        node.None = false;
                        node.panel.BackgroundImage = catImage;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            possibleStates.Clear();
            QGrid.Rows.Clear();

            trainingDone = false;
            CheeseNode = AgentNode = null;
            cheeseExists = agentExists = false;
            
            DeleteGrid();
            InitializeGrid();
        }

        private void DeleteGrid()
        {
            foreach (DictionaryEntry entry in hashtable)
            {
                Node node = (Node)entry.Value;
                this.Controls.Remove(node.panel);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                possibleStates.Clear();
                QGrid.Rows.Clear();

                episodeLabel.Text = "EPISODE 0";

                // initialize Q-Table
                int size = Int32.Parse(gridSize.SelectedItem.ToString());
                int number_of_actions = 4;
                int number_of_states = size * size;

                QTable = new float[number_of_states, number_of_actions];

                for (int state = 0; state < number_of_states; state++)
                {
                    for (int action = 0; action < number_of_actions; action++)
                    {
                        QTable[state, action] = 0.0f;
                    }
                }

                // initialize Reward Table
                Reward = new float[number_of_states, number_of_actions];

                for(int state = 0; state < number_of_states; state++)
                {
                    Node node = (Node)hashtable[state + 1];
                    node.panel.PanelLabel = "0";

                    // if node is not a wall, cheese or cat, add that node to the list of all possible initial states
                    if (node.None)
                        possibleStates.Add(node);

                    int currX = node.X;
                    int currY = node.Y;

                    if (node.Cheese || node.Wall || node.Cat)
                    {
                        Reward[state, (int)Actions.LEFT]  = float.NegativeInfinity;
                        Reward[state, (int)Actions.RIGHT] = float.NegativeInfinity;
                        Reward[state, (int)Actions.UP]    = float.NegativeInfinity;
                        Reward[state, (int)Actions.DOWN]  = float.NegativeInfinity;
                    }
                    else
                    {

                        if (currX - 1 >= 0)
                            Reward[state, (int)Actions.LEFT] = getReward(currY, currX - 1);
                        else
                            Reward[state, (int)Actions.LEFT] = float.NegativeInfinity;

                        if (currX + 1 <= size - 1)
                            Reward[state, (int)Actions.RIGHT] = getReward(currY, currX + 1);
                        else
                            Reward[state, (int)Actions.RIGHT] = float.NegativeInfinity;

                        if (currY - 1 >= 0)
                            Reward[state, (int)Actions.UP] = getReward(currY - 1, currX);
                        else
                            Reward[state, (int)Actions.UP] = float.NegativeInfinity;

                        if (currY + 1 <= size - 1)
                            Reward[state, (int)Actions.DOWN] = getReward(currY + 1, currX);
                        else
                            Reward[state, (int)Actions.DOWN] = float.NegativeInfinity;
                    }
                }

                // create rows for datagridview
                for(int i=0; i<number_of_states; i++)
                {
                    QGrid.Rows.Add();
                }

                // Q Learning Training Process
                Train();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private float getReward(int Y, int X)
        {
            // REWARD
            // 0   - WALL
            // -10 - CAT
            // 10  - CHEESE
            // -1  - NONE

            return (nodes[Y, X].Wall) ? float.NegativeInfinity :
                   (nodes[Y, X].Cat) ? -100f :
                   (nodes[Y, X].Cheese) ? 100f : -1.0f;
        }

        private void Train()
        {
            try
            {
                EPSILON = Convert.ToSingle(Epsilon.Text);
                EPSILON_DECAY_RATE = Convert.ToSingle(EpsilonDecayRate.Text);
                DISCOUNT = Convert.ToSingle(Gamma.Text);
                EPISODES = Convert.ToInt32(Episodes.Text);
                STEPS = Convert.ToInt32(Steps.Text);
            
                if(EPSILON > 1 || EPSILON < 0)
                    throw new Exception("Epsilon must be <= 1 or >= 0!");
            
                if (DISCOUNT > 1 || DISCOUNT < 0)
                    throw new Exception("Gamma must be <= 1 or >= 0!");
            
                if (EPISODES == 0)
                    throw new Exception("Number of episodes must be > 0!");
            
                if (STEPS == 0)
                    throw new Exception("Number of steps must be > 0!");

                // Select initial state
                currentState = randomInitialState();

                // start training timer
                trainingTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void trainingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Node nextState;

                // if training is done
                if (EPISODES == episode)
                {
                    // reset 
                    currentState.panel.BackgroundImage = null;
                    trainingDone = true;
                    step = 0;
                    episode = 0;

                    // stop training timer
                    trainingTimer.Stop();

                    MessageBox.Show("TRAINING DONE!");
                }
                else if (STEPS == step)
                {

                    episode++;
                    episodeLabel.Text = "EPISODE " + episode.ToString();

                    step = 0;

                    EPSILON *= EPSILON_DECAY_RATE;

                    // reset agent to random initial state
                    currentState.panel.BackgroundImage = null;
                    currentState = randomInitialState();
                    currentState.panel.BackgroundImage = mouseImage;
                }
                else
                {
                    current_state = currentState.state - 1;

                    if (random.NextDouble() > EPSILON)
                    {
                        // Exploitation Phase
                        // Select a next state of the current state with the highest Q-value
                        NextState = MaxNextAction(currentState.state);
                    }
                    else
                    {
                        // Exploration Phase
                        // Select a random state from all possible next states of the current state
                        NextState = randomAction(currentState.state);
                    }

                    nextState = NextState.Item1;    // state
                    action = NextState.Item2;       // action

                    // Update Q(state, action)
                    float optimal_future_reward = Max(nextState);
                    float discounted_optimal_future_value = DISCOUNT * optimal_future_reward;
                    float learned_value = Reward[current_state, action] + discounted_optimal_future_value;

                    QTable[current_state, action] = learned_value;

                    // if next state is a cat or a cheese
                    //      reset agent to random initial state and proceed to next episode
                    // else
                    //      move to next state and set next state to current state
                    if (nextState.Cat || nextState.Cheese)
                    {
                        episode++;
                        episodeLabel.Text = "EPISODE " + episode.ToString();

                        step = 0;

                        EPSILON *= EPSILON_DECAY_RATE;

                        // reset agent to random initial state
                        currentState.panel.BackgroundImage = null;
                        currentState = randomInitialState();
                        currentState.panel.BackgroundImage = mouseImage;
                    }
                    else
                    {
                        currentState.panel.BackgroundImage = null;
                        nextState.panel.BackgroundImage = mouseImage;

                        // go to next state
                        currentState = nextState;
                    }

                    Node node = (Node)hashtable[current_state + 1];
                    node.panel.PanelLabel = QTable[current_state, action].ToString();
                }
                
                // display Q-Values to the DataGridView
                int size = Int32.Parse(gridSize.SelectedItem.ToString());
                for(int STATE=0; STATE < size * size; STATE++)
                {
                    QGrid.Rows[STATE].Cells[0].Value = STATE + 1;
                    QGrid.Rows[STATE].Cells[1].Value = QTable[STATE, 0];
                    QGrid.Rows[STATE].Cells[2].Value = QTable[STATE, 1];
                    QGrid.Rows[STATE].Cells[3].Value = QTable[STATE, 2];
                    QGrid.Rows[STATE].Cells[4].Value = QTable[STATE, 3];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get all possible actions of the current state
        private List<Tuple<Node, int>> getPossibleNextActions(int currentState)
        {
            List<Tuple<Node, int>> actionList = new List<Tuple<Node, int>>();
            try
            {
                int size = Int32.Parse(gridSize.SelectedItem.ToString());

                Tuple<Node, int> tuple;
                Node currentNode = (Node)hashtable[currentState];

                // Left
                if (currentNode.X - 1 >= 0)
                {
                    if (!nodes[currentNode.Y, currentNode.X - 1].Wall)
                    {
                        tuple = new Tuple<Node, int>(nodes[currentNode.Y, currentNode.X - 1], 0);
                        actionList.Add(tuple);
                    }
                }

                // Right
                if (currentNode.X + 1 <= size - 1)
                {
                    if (!nodes[currentNode.Y, currentNode.X + 1].Wall)
                    {
                        tuple = new Tuple<Node, int>(nodes[currentNode.Y, currentNode.X + 1], 1);
                        actionList.Add(tuple);
                    }
                }

                // Up
                if (currentNode.Y - 1 >= 0)
                {
                    if (!nodes[currentNode.Y - 1, currentNode.X].Wall)
                    {
                        tuple = new Tuple<Node, int>(nodes[currentNode.Y - 1, currentNode.X], 2);
                        actionList.Add(tuple);
                    }
                }

                // Down
                if (currentNode.Y + 1 <= size - 1)
                {
                    if (!nodes[currentNode.Y + 1, currentNode.X].Wall)
                    {
                        tuple = new Tuple<Node, int>(nodes[currentNode.Y + 1, currentNode.X], 3);
                        actionList.Add(tuple);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return actionList;
        }

        // select a random action from all possible actions of the current state
        private Tuple<Node, int> randomAction(int currentState)
        {
            // get the list of all possible states and actions of the current state
            List<Tuple<Node, int>> possible_states = getPossibleNextActions(currentState);

            Random randomObj = new Random();
            int randomNumber = randomObj.Next(possible_states.Count);

            return possible_states[randomNumber];
        }

        // get the maximum Q-value from all possible next states of the next state
        private float Max(Node nextState)
        {
            // get the list of all possible states and actions of the next state
            List<Tuple<Node, int>> possibleStates = getPossibleNextActions(nextState.state);

            float[] Q = new float[possibleStates.Count];

            float MaxQ = float.NegativeInfinity;
            foreach(Tuple<Node, int> states in possibleStates)
            {
                if(QTable[nextState.state - 1, states.Item2] > MaxQ)
                    MaxQ = QTable[nextState.state - 1, states.Item2];
            }
            
            return MaxQ;
        }
        
        // 
        private Tuple<Node, int> MaxNextAction(int currentState)
        {
            List<Tuple<Node, int>> nextStateList = new List<Tuple<Node, int>>();
            List<Tuple<Node, int>> possible_states = getPossibleNextActions(currentState);
            Node currentNode = (Node)hashtable[currentState];
            
            float MaxQ = Max(currentNode);
            
            foreach(Tuple<Node, int> state in possible_states)
            {
                if (QTable[currentState - 1, state.Item2] == MaxQ)
                    nextStateList.Add(state);
            }

            Random randomObj = new Random();
            int r = randomObj.Next(nextStateList.Count);
            
            return nextStateList[r];
        }
        
        private void stopTrainingBtn_Click(object sender, EventArgs e)
        {
            trainingDone = true;
            trainingTimer.Stop();
            currentState.panel.BackgroundImage = null;
        }

        private void exploitBtn_Click(object sender, EventArgs e)
        {
            if (trainingDone)
            {
                currentState = AgentNode;
                exploitTimer.Start();
            }
        }

        private void exploitTimer_Tick(object sender, EventArgs e)
        {
            Tuple<Node, int> next = MaxNextAction(currentState.state);

            if(next.Item1.Cheese)
            {
                currentState.panel.BackgroundImage = null;
                next.Item1.panel.BackgroundImage = mouseImage;

                exploitTimer.Stop();
                
                var result = MessageBox.Show("CHEESE EATEN!", "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(result == DialogResult.OK)
                {
                    currentState = AgentNode;
                    currentState.panel.BackgroundImage = mouseImage;
                    next.Item1.panel.BackgroundImage = cheeseImage;
                }
            }
            else if(next.Item1.Cat)
            {
                currentState.panel.BackgroundImage = null;
                next.Item1.panel.BackgroundImage = mouseImage;

                exploitTimer.Stop();

                var result = MessageBox.Show("MOUSE EATEN BY THE CAT!", "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    currentState = AgentNode;
                    currentState.panel.BackgroundImage = mouseImage;
                    next.Item1.panel.BackgroundImage = catImage;
                }
            }
            else
            {
                currentState.panel.BackgroundImage = null;
                next.Item1.panel.BackgroundImage = mouseImage;
                currentState = next.Item1;
            }
        }

        private Node randomInitialState()
        {
            Random rand = new Random();
            int r = rand.Next(possibleStates.Count);

            return possibleStates[r];
        }
    }
}