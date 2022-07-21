using System;
using System.Collections.Generic;
using System.Text;


public class Member
{
	private string _name;
	private int _id;
	public Member(string name, int id)
	{
		_name = name;
		_id = id;
	}
	public string Name { get { return _name; } }
	public int Id { get { return _id; } }
}

