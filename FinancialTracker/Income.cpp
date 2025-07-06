#include "Income.h"

int Income::GetAmount()
{
	return m_amount;
}

IncomeType Income::GetType()
{
	return m_type;
}

void Income::SetAmount(int amount)
{
	m_amount = amount;
}

void Income::SetType(IncomeType type)
{
	m_type = type;
}