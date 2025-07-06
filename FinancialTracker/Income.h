#pragma once

enum IncomeType
{
	Salary,
	Business,
	StockTrading,
	BankInterest,
	Dividend
};

class IIncome
{
public:
	virtual int GetAmount() = 0;
	virtual IncomeType GetType() = 0;

	virtual void SetAmount(int amount) = 0;
	virtual void SetType(IncomeType type) = 0;
};

class Income : public IIncome
{
public:
	int GetAmount() override;
	IncomeType GetType() override;

	void SetAmount(int amount) override;
	void SetType(IncomeType type) override;

private:
	IncomeType m_type;
	int m_amount;
};