#pragma once

enum ExpenseType
{
	Gneneral
};
class IExpense
{
public:
	virtual int GetAmount() = 0;
	virtual ExpenseType GetType() = 0;

	virtual void SetAmount(int amount) = 0;
	virtual void SetType(ExpenseType type) = 0;
};

class Expense : public IExpense
{
public:
	int GetAmount() override;
	ExpenseType GetType() override;

	void SetAmount(int amount) override;
	void SetType(ExpenseType type) override;

private:
	ExpenseType m_type;
	int m_amount;
};