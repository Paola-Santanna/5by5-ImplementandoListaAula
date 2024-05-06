using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementando_Lista___aula_13
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            if (isEmpty())
            {
                this.head = contact;
                this.tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;

                    do
                    {
                        compare = string.Compare(contact.getName(), aux.getName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }

                    } while (aux != null && compare > 0);

                    prev.setNext(contact);
                    contact.setNext(aux);
                    if (aux == null)
                        tail = contact;
                }
            }
        }

        bool isEmpty()
        {
            if (this.head == null && this.tail == null)
                return true;
            else
                return false;
        }

    }
}