using System.Data.Common;

namespace practical_exam
{
    public partial class Form1 : Form
    {
        FileStream fileStream;
        StreamReader reader;
        StreamWriter writer;
        String fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openfileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            DialogResult dialogResult= openFileDialog.ShowDialog();
            if(dialogResult == DialogResult.Cancel)
            {
                return;
            }
             fileName= openFileDialog.FileName;
            fileStream=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            reader = new StreamReader(fileStream);
            writer = new StreamWriter(fileStream);
            MessageBox.Show("File Opened Successfuly");
            insertBtn.Enabled = true;
            readBtn.Enabled = true;
            searchBtn.Enabled = true;
            deleteBtn.Enabled = true; 
            squezzeBtn.Enabled = true;
            clearFomBtn.Enabled = true;
            closeFileBtn.Enabled = true;
            endFileBtn.Enabled= true;
            startFileBtn.Enabled=true;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFomBtn_Click(object sender, EventArgs e)
        {
            ID.Text= null;
            firstName.Text= null; 
            LastName.Text= null;
            balance.Text= null; 
        }

        private void closeFileBtn_Click(object sender, EventArgs e)
        {
            // while running my code i have found an error its must to close write first
            writer.Close();
            reader.Close();
            fileStream.Close();
            MessageBox.Show("File is closed successfuly");
            insertBtn.Enabled = false;
            readBtn.Enabled = false;
            searchBtn.Enabled = false;
            deleteBtn.Enabled = false;
            squezzeBtn.Enabled = false;
            clearFomBtn.Enabled = false;
            closeFileBtn.Enabled = false;
            endFileBtn.Enabled = false;
            startFileBtn.Enabled = false;

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            String record = ID.Text + "," + firstName.Text + "," + LastName.Text + ","+balance.Text;
            writer.WriteLine(record);
            writer.Flush();
            MessageBox.Show("record saved");
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            String record=reader.ReadLine();
            String[] fields;
            if(record!=null) 
            {
                fields=record.Split(',');
                ID.Text= fields[0];
                firstName.Text= fields[1];
                LastName.Text= fields[2];

            }
            else
            {
                MessageBox.Show("There are no records");
                clearFomBtn_Click(sender, e);
            }
        }

        private void startFileBtn_Click(object sender, EventArgs e)
        {
            fileStream.Seek(0, SeekOrigin.Begin);
            MessageBox.Show("Beginig of the file");

        }

        private void endFileBtn_Click(object sender, EventArgs e)
        {
            fileStream.Seek(0, SeekOrigin.End);
            MessageBox.Show("End of the file");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            firstName.Text = LastName.Text = balance.Text = null ;
            int id=int.Parse(ID.Text);
            String record;
            String[] fields;
            while ((record = reader.ReadLine()) != null)
            {
               fields= record.Split(",");
                if (id == int.Parse(fields[0]))
                {
                    firstName.Text = fields[1];
                    LastName.Text=fields[2];
                    balance.Text = fields[3];
                    MessageBox.Show("user found");
                    return;
                }
            }
            MessageBox.Show("user not found");

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            firstName.Text=LastName.Text = balance.Text=null ;
            fileStream.Seek(0, SeekOrigin.Begin);
            fileStream.Flush();
            writer.Flush();

            String record;
            String[] fields;
            int steps = 0;
            int id = int.Parse(ID.Text);
            while((record = reader.ReadLine()) != null)
            {
                fields= record.Split(",");
                if (id == int.Parse(fields[0]))
                {
                    fileStream.Seek(steps, SeekOrigin.Begin);
                    writer.Write("*");
                    writer.Flush();
                    MessageBox.Show("record deleted ");
                }
                steps += record.Length + 2;
            }
        }

        private void squezzeBtn_Click(object sender, EventArgs e)
        {
            String record;
            fileStream.Seek(0,SeekOrigin.Begin);
            FileStream SqueezeFileStream=new FileStream("squezzedfile.txt",FileMode.Create,FileAccess.Write);
            StreamWriter SqueezeWriter= new StreamWriter(SqueezeFileStream);
            while ((record=reader.ReadLine())!=null) 
            {
                if (record[0] != '*')
                {
                    SqueezeWriter.WriteLine(record);
                    SqueezeWriter.Flush();
                   
                }
                
                
            }
            SqueezeWriter.Close();
            SqueezeFileStream.Close();
            MessageBox.Show("Squezed succesfully");

        }
    }
}