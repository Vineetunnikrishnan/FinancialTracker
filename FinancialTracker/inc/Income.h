#pragma once

class IIncome
{
	virtual int		GetIncome() = 0;
	virtual void	SetIncome(int amount) = 0;
};

class Income : IIncome
{
private:
	int amount;

};