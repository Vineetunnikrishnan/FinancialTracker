#pragma once

class IPersist
{
public:
	virtual void Save() = 0;
};

class File : public IPersist
{
private:

};