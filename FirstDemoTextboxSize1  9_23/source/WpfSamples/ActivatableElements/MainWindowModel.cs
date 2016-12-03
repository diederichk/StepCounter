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
            _notes.Add(new Note(activatedNote.Id, activatedNote.ColumnIndex,
                activatedNote.RowIndex, Colors.Yellow, System.Windows.Media.Brushes.Red));
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
            notes.Add(new Note(id++, 0, 0, Colors.White,System.Windows.Media.Brushes.DarkBlue ));                   // 1
            notes.Add(new Note(id++, 1, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 18, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 19, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 0, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19

            notes.Add(new Note(id++, 0, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 1, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19


            notes.Add(new Note(id++, 0, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 2, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19


            notes.Add(new Note(id++, 0, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17            
            notes.Add(new Note(id++, 19, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 3, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19


            notes.Add(new Note(id++, 0, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 16, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 17, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 4, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19

            notes.Add(new Note(id++, 0, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 13
            notes.Add(new Note(id++, 13, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 5, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19

            notes.Add(new Note(id++, 0, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   //9
            notes.Add(new Note(id++, 9, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   //13
            notes.Add(new Note(id++, 13, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 6, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19

            notes.Add(new Note(id++, 0, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   //9
            notes.Add(new Note(id++, 9, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   //13
            notes.Add(new Note(id++, 13, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 7, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19

            notes.Add(new Note(id++, 0, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 1
            notes.Add(new Note(id++, 1, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 2
            notes.Add(new Note(id++, 2, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 3
            notes.Add(new Note(id++, 3, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 4
            notes.Add(new Note(id++, 4, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 5
            notes.Add(new Note(id++, 5, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 6
            notes.Add(new Note(id++, 6, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 7
            notes.Add(new Note(id++, 7, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 8
            notes.Add(new Note(id++, 8, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 9
            notes.Add(new Note(id++, 9, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 10
            notes.Add(new Note(id++, 10, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 11
            notes.Add(new Note(id++, 11, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 12
            notes.Add(new Note(id++, 12, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   //13
            notes.Add(new Note(id++, 13, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 14
            notes.Add(new Note(id++, 14, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 15
            notes.Add(new Note(id++, 15, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 16, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 17, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 16
            notes.Add(new Note(id++, 18, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 17
            notes.Add(new Note(id++, 19, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 20, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19
            notes.Add(new Note(id++, 21, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 18
            notes.Add(new Note(id++, 22, 8, Colors.White, System.Windows.Media.Brushes.DarkBlue));                   // 19




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
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                
                // 2
                "2",
                "forest.",
                "One",
                "day",
                "after",
                "a",
                "heavy",
                "meal.",
                "It",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",


                // 3
                "3",
                "sleeping",
                "under",
                "a",
                "tree.",
                "After",
                "a",
                "while,",
                "there",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 4
                "4",
                "a",
                "mouse",
                "and",
                "it",
                "started",
                "to",
                "play",
                "on",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 5
                "5",
                "lion.",
                "Suddenly",
                "the",
                "lion",
                "got",
                "up",
                "with",
                "anger",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 6
                "6",
                "looked",
                "for",
                "those",
                "who",
                "disturbed",
                "its",
                "nice",
                "sleep.",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 7
                "7",
                "it",
                "saw",
                "a",
                "small",
                "mouse",
                "standing",
                "trembling",
                "with",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 8
                "8",
                "The",
                "lion",
                "jumped",
                "on",
                "it",
                "and",
                "started",
                "to",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",

                // 9
                "9",
                "it.",
                "The",
                "mouse",
                "requested",
                "the",
                "loin",
                "to",
                "forgive",
                "1",
                "2",
                "3",
                "4",
                "there",
                "lived",
                "upon",
                "a",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",




            }; 

        public Note(int id, int columnIndex, int rowIndex, Color backgroundColor,
                 System.Windows.Media.Brush foregroundColor )
        {
            Id = id;
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
            Text = quotes[id];
            BackgroundColor = new SolidColorBrush(backgroundColor);
            ForegroundColor = foregroundColor;
        }

        public int Id { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public string Text { get; set; }
        public SolidColorBrush BackgroundColor { get; set; }
        public System.Windows.Media.Brush ForegroundColor { get; set; }
    }
}
