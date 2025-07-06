#pragma once

enum InvestmentType
{
	Stock,
	MutualFund,
	SGB,
	ETF,
	Securities,
	BankAccount,
	FD,
	PPF,
	EPF,
	NPS
};

class IInvestment
{
public:
	virtual int GetAmount() = 0;
	virtual InvestmentType GetType() = 0;

	virtual void SetAmount(int amount) = 0;
	virtual void SetType(InvestmentType type) = 0;
};

class Investment : public IInvestment
{
public:
	int GetAmount() override;
	InvestmentType GetType() override;

	void SetAmount(int amount) override;
	void SetType(InvestmentType type) override;

private:
	InvestmentType m_type;
	int m_amount;
};