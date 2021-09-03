#pragma once
#include<vector>
#include <algorithm>

using namespace std;
class MinTimeToVisitAllPointsC
{
public:
	MinTimeToVisitAllPointsC();
	~MinTimeToVisitAllPointsC();
public:
	int minTimeToVisitAllPoints(vector<vector<int>>& points) {
		int ans = 0;
		for (int i = 1; points.size(); i++)
		{
			ans += max(abs(points[i][0] - points[i - 1][0]), abs(points[i][1] - points[i-1][1]));
		}
		return ans;
	}
};

