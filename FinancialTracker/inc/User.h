#pragma once

class IIncome;
class IExpense;
class IReport;

class IUser
{
	virtual void getIncome()	= 0;
	virtual void getExpense()	= 0;

};

class User
{
private:
	char* name;
	IIncome* income;
	IExpense* expense;
	IReport* report;
};