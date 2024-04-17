using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARyzhova_Assignment3
{
    public class Contact
    {
        string firstName;
        string lastName;
        public string AddressType;
        public string Street;
        public string City;
        public string Province;
        public string Zip;
        public string Email;
        public string EmailType;
        public string Phone;
        public string PhoneType;
        public string PathToImage;
        public string PathToNotes;
        public List<Note> NoteList;
        

        public string FirstName
        {
            get => firstName;
        }

        public string LastName
        {
            get => lastName;
        }
        public Contact(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            NoteList = new List<Note>();
            PathToNotes = $"{firstName.Substring(0, 2)}{lastName.Substring(0, 2)}{DateTime.Now.Ticks}.txt";
        }

        public Contact(string firstName, string lastName, 
                       string addressType,
                       string street,
                       string city, 
                       string province, 
                       string zip,
                       string email,
                       string emailType,
                       string phone,
                       string phoneType,
                       string pathToImage) 
                      :this (firstName, lastName)
        {
            this.AddressType = addressType;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
            this.Email = email;
            this.EmailType = emailType;
            this.Phone = phone;
            this.PhoneType = phoneType;
            this.PathToImage = pathToImage;
        }

        /// <summary>
        /// Adding notes to the list in reverse order
        /// </summary>
        /// <param name="note"></param>
        public void AddNote(Note note)
        {
            NoteList.Reverse();
            NoteList.Add(note);
            NoteList.Reverse();
        }

        /// <summary>
        /// Method used to display update notes section in order
        /// to display them from newest to oldest
        /// </summary>
        /// <returns></returns>
        public string DisplayNotes()
        {
            StringBuilder str = new StringBuilder();
            foreach (Note note in NoteList)
            {
               str.AppendLine( $"{note.DateAndTime}\r\n {note.Text}\r\n");
            }

            return str.ToString();
        }

        internal void AppendToFile(StreamWriter wr)
        {
            wr.WriteLine($"{FirstName}|" +
                        $"{LastName}|" +
                        $"{AddressType}|" +
                        $"{Street}|" +
                        $"{City}|" +
                        $"{Province}|" +
                        $"{Zip}|" +
                        $"{Email}|" +
                        $"{EmailType}|" +
                        $"{Phone}|" +
                        $"{PhoneType}|" +
                        $"{PathToImage}|" +
                        $"{PathToNotes}");

            using (StreamWriter notewr = new StreamWriter(PathToNotes))
            {
                foreach(Note note in NoteList)
                {
                    note.AppendToFile(notewr);
                }
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
