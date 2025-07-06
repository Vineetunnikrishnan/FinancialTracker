#include "Investment.h"

int Investment::GetAmount()
{
	return m_amount;
}

InvestmentType Investment::GetType()
{
	return m_type;
}

void Investment::SetAmount(int amount)
{
	m_amount = amount;
}

void Investment::SetType(InvestmentType type)
{
	m_type = type;
}