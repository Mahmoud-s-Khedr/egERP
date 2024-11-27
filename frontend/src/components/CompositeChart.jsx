import React from 'react';
import { useTheme } from '../context/Theme';
import {
  ComposedChart,
  Line,
  Area,
  Bar,
  XAxis,
  YAxis,
  CartesianGrid,
  Tooltip,
  Legend,
  ResponsiveContainer,
} from 'recharts';

const data = [
  { name: 'Jan', customers: 100, orders: 150, revenue: 400 },
  { name: 'Feb', customers: 120, orders: 200, revenue: 500 },
  { name: 'Mar', customers: 140, orders: 180, revenue: 400 },
  { name: 'Apr', customers: 160, orders: 220, revenue: 600 },
  { name: 'May', customers: 200, orders: 250, revenue: 800 },
  { name: 'Jun', customers: 180, orders: 230, revenue: 750 },
  { name: 'Jul', customers: 220, orders: 300, revenue: 900 },
  { name: 'Aug', customers: 210, orders: 290, revenue: 800 },
  { name: 'Sep', customers: 190, orders: 270, revenue: 800 },
  { name: 'Oct', customers: 240, orders: 310, revenue: 90 },
  { name: 'Nov', customers: 230, orders: 320, revenue: 400 },
  { name: 'Dec', customers: 250, orders: 350, revenue: 100 },
];

const CompositeChart = () => {
  const {theme}=useTheme();
  console.log(theme);

  return (
    <ResponsiveContainer width="100%" height={400}>
      <ComposedChart
        data={data}
        margin={{
          top: 20,
          right: 20,
          bottom: 20,
          left: 20,
        }}
      >
        <CartesianGrid stroke="#f0f0f0" />
        <XAxis dataKey="name" scale="band" />
        <YAxis />
        <Tooltip />
        <Legend />
        {/* Revenue Area */}
        <Area type="monotone" dataKey="revenue" fill={theme.primary} stroke={theme.primary} name="Revenue ($)" />
        {/* Orders Bar */}
        <Bar dataKey="orders" barSize={20} fill={theme.secondary} name="Orders" />
        {/* Customers Line */}
        <Line type="monotone" dataKey="customers" stroke={theme.tertiary} name="Customers" />
      </ComposedChart>
    </ResponsiveContainer>
  );
};

export default CompositeChart;
