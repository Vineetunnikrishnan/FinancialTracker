#pragma once
#include <vector>

enum EssentialExpenseType
{
	Rent,
	LoanEMI,
	Grocery,
	Vegetables,
	WaterBill,
	ElectricityBill,
	GasBill,
	Maintenence,
	PhoneBill,
	WifiBill,
	Medical
};

enum LuxuryExpenseType
{
	Shopping,
	Entertainment,
	Travel,
	OutstationTravel,
	Furniture,
	Electronics,
	Cosmetics
};

class IExpense
{
	virtual unsigned int GetExpense(EssentialExpenseType) = 0;
	virtual unsigned int GetExpense(LuxuryExpenseType) = 0;
	virtual unsigned int GetExpense(char* miscExpense) = 0;

	virtual void SetExpense(EssentialExpenseType,	unsigned int amount) = 0;
	virtual void SetExpense(LuxuryExpenseType,		unsigned int amount) = 0;
	virtual void SetExpense(char* miscExpense,		unsigned int amount) = 0;
};

class Expense : public IExpense
{
private:
	std::vector<EssentialExpenseType, int>	eExpenses;
	std::vector<LuxuryExpenseType, int>		lExpenses;
	std::vector<char*, int>					miscExpenses;
};