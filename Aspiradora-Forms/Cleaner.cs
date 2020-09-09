using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspiradora_Forms
{
    public enum Direction
    {
        LEFT,
        RIGHT
    }

    public enum Orientation
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

    public class Cleaner
    {
        public int MaxRows { get; set; }
        public int MaxColumns { get; set; }

        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
        public bool Enabled { get; set; }
        public Orientation Orientation { get; set; }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    if (CanMove(direction))
                    {
                        switch (Orientation)
                        {
                            case Orientation.NORTH:
                                ColumnIndex--;
                                Orientation = Orientation.EAST;
                                break;
                            case Orientation.EAST:
                                RowIndex--;
                                Orientation = Orientation.NORTH;
                                break;
                            case Orientation.SOUTH:
                                ColumnIndex++;
                                Orientation = Orientation.EAST;
                                break;
                            case Orientation.WEST:
                                RowIndex++;
                                Orientation = Orientation.SOUTH;
                                break;
                            default:
                                break;
                        }
                        Debug.WriteLine("Cleaner movió a la izquierda. " + ColumnIndex + ", " + RowIndex);
                    }
                    else Debug.WriteLine("Cleaner no pudo moverse a la izquieda. " + ColumnIndex + ", " + RowIndex); 
                    break;

                case Direction.RIGHT:
                    if (CanMove(direction))
                    {

                        switch (Orientation)
                        {
                            case Orientation.NORTH:
                                ColumnIndex++;
                                Orientation = Orientation.EAST;
                                break;
                            case Orientation.EAST:
                                RowIndex++;
                                Orientation = Orientation.SOUTH;
                                break;
                            case Orientation.SOUTH:
                                ColumnIndex--;
                                Orientation = Orientation.WEST;
                                break;
                            case Orientation.WEST:
                                RowIndex--;
                                Orientation = Orientation.NORTH;
                                break;
                            default:
                                break;
                        }
                        Debug.WriteLine("Cleaner movió a la derecha. " + ColumnIndex + ", " + RowIndex);
                    }
                    else Debug.WriteLine("Cleaner no pudo moverse a la derecha. " + ColumnIndex + ", " + RowIndex);
                    break;
                default:
                    break;
            }
        }

        public bool CanMove(Direction direction)
        {
            switch (direction)  
            {
                case Direction.LEFT:
                    switch (Orientation)
                    {
                        case Orientation.NORTH:
                            return ColumnIndex.HasValue && ColumnIndex.Value - 1 >= 0;
                        case Orientation.EAST:
                            return RowIndex.HasValue && RowIndex.Value - 1 >= 0;
                        case Orientation.SOUTH:
                            return ColumnIndex.HasValue && ColumnIndex.Value + 1 < MaxColumns; 
                        case Orientation.WEST:
                            return RowIndex.HasValue && RowIndex.Value + 1 < MaxRows;
                        default:
                            return false;
                    }
                case Direction.RIGHT:
                    switch (Orientation)
                    {
                        case Orientation.NORTH:
                            return ColumnIndex.HasValue && ColumnIndex.Value + 1 < MaxColumns;
                        case Orientation.EAST:
                            return RowIndex.HasValue && RowIndex.Value + 1 < MaxRows;
                        case Orientation.SOUTH:
                            return ColumnIndex.HasValue && ColumnIndex.Value - 1 >= 0;
                        case Orientation.WEST:
                            return RowIndex.HasValue && RowIndex.Value - 1 >= 0;
                        default:
                            return false;
                    }
                default:
                    return false;
            }

        }

        public static bool IsValid(Cleaner cleaner)
        {
            return cleaner != null && cleaner.ColumnIndex.HasValue && cleaner.RowIndex.HasValue;
        }



    }

   


}
