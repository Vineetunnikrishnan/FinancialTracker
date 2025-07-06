#include "Expense.h"

int Expense::GetAmount()
{
	return m_amount;
}

ExpenseType Expense::GetType()
{
	return m_type;
}

void Expense::SetAmount(int amount)
{
	m_amount = amount;
}

void Expense::SetType(ExpenseType type)
{
	m_type = type;
}