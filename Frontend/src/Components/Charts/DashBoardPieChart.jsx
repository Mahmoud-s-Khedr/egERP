import React, { PureComponent } from 'react';
import { PieChart, Pie, Legend, Tooltip, ResponsiveContainer } from 'recharts';

const data01 = [
  { name: 'Group A', value: 400 },
  { name: 'Group B', value: 300 },
  { name: 'Group C', value: 300 },
  { name: 'Group D', value: 200 },
  { name: 'Group E', value: 278 },
  { name: 'Group F', value: 189 },
];
function DashBoardPieChart() {

    return (
      <>
      <header className='fw-semibold pie-chart p-1'>Customers per Country</header>
      <ResponsiveContainer width="100%" className="pie-chart pie-chart-height" >
        <PieChart width={400} height={400}>
          <Pie
            dataKey="value"
            isAnimationActive={false}
            data={data01}
            cx="50%"
            height="600"
            width="600"
            cy="50%"
            outerRadius={120}
            fill="#8884d8"
            label
          />
          <Tooltip />
        </PieChart>
      </ResponsiveContainer>
      </>
    );
  }

export default DashBoardPieChart;