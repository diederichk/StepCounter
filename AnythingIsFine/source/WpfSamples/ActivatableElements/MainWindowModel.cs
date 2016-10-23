//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

namespace ActivatableElements
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Data;
    using System.Windows.Media;
    using System;

    public class MainWindowModel
    {
        private readonly ObservableCollection<Note> _notes;
        private readonly ICollectionView _notesView;

        public MainWindowModel()
        {
            _notes = CreateNotes();
            _notesView = CollectionViewSource.GetDefaultView(_notes);
        }

        /// <summary>
        /// A collection of notes to be displayed in the sample window.
        /// </summary>
        public ICollectionView Notes
        {
            get { return _notesView; }
        }

        /// <summary>
        /// Removes the activated note.
        /// </summary>
        /// <param name="activatedNote"></param>
        public void ActivateNote(Note activatedNote)
        {
            Console.Write("Activated note:" + activatedNote.Text);
            _notes.Remove(activatedNote);
        }

        /// <summary>
        /// Restores all notes.
        /// </summary>
        public void RestoreWisdom()
        {
            _notes.Clear();
            InitializeNotes(_notes);
        }

        private ObservableCollection<Note> CreateNotes()
        {
            var notes = new ObservableCollection<Note>();
            InitializeNotes(notes);
            return notes;
        }

        private void InitializeNotes(ObservableCollection<Note> notes)
        {   // Possible Ranges (0-8),(0-10)
            var id = 0;
            notes.Add(new Note(id++, 0, 0, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 0, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 0, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 0, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 0, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 0, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 0, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 0, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 0, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 1, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 1, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 1, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 1, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 1, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 1, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 1, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 1, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 1, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 2, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 2, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 2, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 2, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 2, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 2, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 2, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 2, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 2, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 3, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 3, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 3, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 3, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 3, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 3, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 3, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 3, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 3, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 4, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 4, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 4, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 4, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 4, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 4, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 4, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 4, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 4, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 5, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 5, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 5, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 5, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 5, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 5, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 5, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 5, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 5, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 6, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 6, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 6, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 6, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 6, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 6, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 6, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 6, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 6, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 7, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 7, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 7, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 7, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 7, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 7, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 7, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 7, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 7, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 8, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 8, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 8, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 8, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 8, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 8, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 8, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 8, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 8, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 9, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 9, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 9, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 9, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 9, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 9, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 9, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 9, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 9, Colors.Aqua));                   // 9

            notes.Add(new Note(id++, 0, 10, Colors.Aqua));                   // 1
            notes.Add(new Note(id++, 1, 10, Colors.Aquamarine));             // 2
            notes.Add(new Note(id++, 2, 10, Colors.LightPink));              // 3
            notes.Add(new Note(id++, 3, 10, Colors.LightGoldenrodYellow));   // 4
            notes.Add(new Note(id++, 4, 10, Colors.Aqua));                   // 5
            notes.Add(new Note(id++, 5, 10, Colors.Aquamarine));             // 6
            notes.Add(new Note(id++, 6, 10, Colors.LightPink));              // 7
            notes.Add(new Note(id++, 7, 10, Colors.LightGoldenrodYellow));   // 8
            notes.Add(new Note(id++, 8, 10, Colors.Aqua));                   // 9
        }
    }

    /// <summary>
    /// Represents a note with a quote, and its placement in the sample window.
    /// </summary>
    public class Note
    {
        private readonly List<string> quotes = new List<string>()
            {
            // 1
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 2
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 3
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 4
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 5
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 6
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 7
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 8
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 9
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 10
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                // 11
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
            }; 

        public Note(int id, int columnIndex, int rowIndex, Color backgroundColor)
        {
            Id = id;
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
            Text = quotes[id];
            BackgroundColor = new SolidColorBrush(backgroundColor);
        }

        public int Id { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public string Text { get; set; }
        public SolidColorBrush BackgroundColor { get; set; }
    }
}
