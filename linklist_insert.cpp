// This is a C++ console application, which creates a linked list by 
// inserting the elements at the start, inserting at the middle, 
// inserting at the end of the list. It also prints ths list elements on the 
// console.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

struct Node
{
	int data;
	Node* next;
};

void InsertAtStart(Node** head, int data)
{    
	if (*head == NULL)
	{ 
		(*head) = new Node();
		(*head)->data = data;
		(*head)->next = NULL;        
		return;
	}

	Node* temp = new Node();
	temp->data = data;
	temp->next = *head;
	*head = temp;   
}

void InsertAtEnd(Node** head, int data)
{
	Node* temp = *head;

	while (temp->next != NULL)
	{
		temp = temp->next;
	}

	Node* lastElem = new Node();
	lastElem->data = data;
	lastElem->next = NULL;

	temp->next = lastElem;
}

void InsertInMiddle(Node** head, int data, int index)
{
	Node* temp = *head;
	int count = 1; // index of each element, first element index being 1

	while (temp != NULL && count != index)
	{
		temp = temp->next;
		++count;
	}

	Node* lastElem = new Node();
	lastElem->data = data;
	lastElem->next = NULL;

	lastElem->next = temp->next;
	temp->next = lastElem;
}

void PrintList(Node* head)
{
	Node* temp = head;

	while (temp != NULL)
	{
		cout << temp->data << "->";
		temp = temp->next;
	}

	if (temp == NULL)
	{
		cout << "NULL";
	}

	cout << endl;
}

//Client code to test the above functions
int main()
{
	Node* head = NULL;
	InsertAtStart(&head, 1);
	InsertAtStart(&head, 2);
	InsertAtEnd(&head, 0);
	InsertAtEnd(&head, 10);
	InsertAtEnd(&head, 16);
	InsertAtStart(&head, 11);
	InsertInMiddle(&head, 14, 2);
	InsertInMiddle(&head, 18, 4);
	PrintList(head);
	return 0;
}

