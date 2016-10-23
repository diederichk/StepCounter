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
        {
            var id = 0;
            notes.Add(new Note(id++, 0, 0, Colors.Aqua));
            notes.Add(new Note(id++, 1, 0, Colors.Aquamarine));
            notes.Add(new Note(id++, 2, 0, Colors.LightPink));
            notes.Add(new Note(id++, 3, 0, Colors.LightGoldenrodYellow));
            notes.Add(new Note(id++, 4, 0, Colors.Aqua));
            notes.Add(new Note(id++, 5, 0, Colors.Aquamarine));
            notes.Add(new Note(id++, 6, 0, Colors.LightPink));
            notes.Add(new Note(id++, 7, 0, Colors.LightGoldenrodYellow));
            notes.Add(new Note(id++, 8, 0, Colors.Aqua));
            notes.Add(new Note(id++, 8, 10, Colors.LightPink));
        }
    }

    /// <summary>
    /// Represents a note with a quote, and its placement in the sample window.
    /// </summary>
    public class Note
    {
        private readonly List<string> quotes = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
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
