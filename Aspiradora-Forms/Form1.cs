using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspiradora_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        const int COLUMNS = 10;
        const int ROWS = 10;
        const int POSSIBILTY = 50;

        Cleaner cleaner;



        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEnvironment.Columns.Clear();

            for (int i = 0; i < COLUMNS; i++)
            {
                DataGridViewImageColumn column = new DataGridViewImageColumn(false);
                column.DefaultCellStyle.NullValue = null;
                dgvEnvironment.Columns.Add(column);
            }
            dgvEnvironment.DataSource = bsEnvironment;

            AddPlaces();
            Start();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AddPlaces();
        }

        void AddPlaces()
        {
            bsEnvironment.Clear();
            cleaner = null;
            for (int i = 0; i < ROWS; i++)
            {
                List<Place> places = new List<Place>();
                for (int j = 0; j < COLUMNS; j++) places.Add(new Place() { Row = i, Column = j, State = CalculatePlaceState() });
                bsEnvironment.Add(new PlaceRow() { Places = places });
            }
            btnCleaner.Enabled = true;

        }


        void Start()
        {
            //COLUMNS = random.Next(0, Convert.ToInt32(nudMaxColumns.Value));
            //ROWS = random.Next(0, Convert.ToInt32(nudMaxRows.Value));

            //MapPlaces();
            GenerateTrash();
        }

        
        void GenerateTrash()
        {/*
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    bool result = CalculatePlaceState();
                    dgvEnvironment.Rows[i].Cells[j].Value = result;
                }
            }*/

        }


        PlaceState CalculatePlaceState(int value = POSSIBILTY)
        {
            int randResult = random.Next(0, 100);
            if (randResult >= 0 && randResult <= Convert.ToInt32(value)) return PlaceState.DIRTY;
            else return PlaceState.CLEAN;
        }

        private void dgvEnvironment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            GenerateCleaner();
        }

        void GenerateCleaner()
        {
            if (cleaner != null) if (cleaner.RowIndex.HasValue)
                {
                    int oldIndex = cleaner.RowIndex.Value;
                    bsEnvironment.ResetItem(oldIndex);
                    cleaner = null;
                    bsEnvironment.ResetItem(oldIndex);
                }

            int randRow = random.Next(0, ROWS);
            int randCol = random.Next(0, COLUMNS);

            object placeRowObj = bsEnvironment.List[randRow];

            PlaceRow placeRow = placeRowObj as PlaceRow;

            Place place = placeRow.Places[randCol];

            cleaner = new Cleaner() {  ColumnIndex = randCol, RowIndex = randRow, Enabled = true, MaxColumns = COLUMNS, MaxRows = ROWS, Orientation = Orientation.NORTH };

            bsEnvironment.ResetItem(randRow);

            btnCleaner.Enabled = false;
        }

        void UpdateCleaner(int oldRowIndex, int newRowIndex)
        {
            UpdateDGVRow(oldRowIndex);
            UpdateDGVRow(newRowIndex);
        }


        private void bsEnvironment_ListChanged(object sender, ListChangedEventArgs e)
        {
            

            try
            {
                if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemDeleted)
                {
                    UpdateDGVRow(e.NewIndex);


                }
            }
            catch (Exception)
            {

            }

        }

        void UpdateDGVRow(int row)
        {
            try
            {

            foreach (DataGridViewImageCell item in dgvEnvironment.Rows[row].Cells)
            {
                Place place = (bsEnvironment[item.RowIndex] as PlaceRow).Places[item.ColumnIndex];

                if (Cleaner.IsValid(cleaner))
                {
                    if(item.ColumnIndex == cleaner.ColumnIndex.Value && item.RowIndex == cleaner.RowIndex.Value)
                    {
                    item.Value = Images.RotateImage(Resources.cleaner, 90 * Convert.ToInt32(cleaner.Orientation), true, true, Color.Transparent);
                    item.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            place.State = PlaceState.CLEAN;
                            bsEnvironment.EndEdit();
                    }

                    else
                    {
                        switch (place.State)
                        {
                            case PlaceState.DIRTY:
                                item.Value = Images.RotateImage(Resources.Mugre2, new Random().Next(0, 360), true, true, Color.Transparent);
                                item.ImageLayout = DataGridViewImageCellLayout.Zoom;
                                break;
                            default:
                                item.Value = null;
                                break;
                        }
                    }
                }
                else 
                {
                    switch (place.State)
                    {
                        case PlaceState.DIRTY:
                            item.Value = Images.RotateImage(Resources.Mugre2, new Random().Next(0, 360), true, true, Color.Transparent);
                            item.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            break;
                        default:
                            item.Value = null;
                            break;
                    }
                }
            }
            }
            catch(Exception)
            {

            }
        }




        private void dgvEnvironment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            timerCleaner.Enabled = true;
        }



        private void timerCleaner_Tick(object sender, EventArgs e)
        {
            if(Cleaner.IsValid(cleaner))
            {
                //MoveCleaner(random.Next(100) < 50 ? Direction.LEFT : Direction.RIGHT);
                
            }
        }

        void MoveCleanerTo(int x, int y)
        {
            if(Cleaner.IsValid(cleaner))
            {
                while(cleaner.RowIndex != x || cleaner.ColumnIndex != y)
                {
                    if (y >= cleaner.ColumnIndex) MoveCleaner(Direction.LEFT);
                    else MoveCleaner(Direction.RIGHT);
                    if (x >= cleaner.RowIndex) MoveCleaner(Direction.RIGHT);
                    else MoveCleaner(Direction.LEFT);
                    Thread.Sleep(500);
                }
            }
        }

        void MoveCleaner(Direction direction)
        {
            if(Cleaner.IsValid(cleaner))
            {
                int oldRowIndex = cleaner.RowIndex.Value, oldColumnIndex = cleaner.ColumnIndex.Value;
                bsEnvironment.EndEdit();
                int posibilidad = random.Next(100);
                cleaner.Move(direction);
                int newRowIndex = cleaner.RowIndex.Value, newColumnIndex = cleaner.ColumnIndex.Value;
                UpdateCleaner(oldRowIndex, newRowIndex);
                
            }

        }


        private void dgvEnvironment_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            if(Cleaner.IsValid(cleaner))
            {
                int x = random.Next(cleaner.ColumnIndex.Value, COLUMNS), y = random.Next(cleaner.RowIndex.Value, ROWS);
                Debug.WriteLine("El cleaner se moverá a: " + x + ", " + y + ".");
                MoveCleanerTo(x, y);

            }

        }
    }
}
