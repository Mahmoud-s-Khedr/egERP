import React from 'react';
import { BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid, ResponsiveContainer, Tooltip } from 'recharts';
import { useTheme } from '../context/Theme';



const data = [
  { name: 'Jan', orders: 300 },
  { name: 'Feb', orders: 450 },
  { name: 'Mar', orders: 200 },
  { name: 'Apr', orders: 500 },
  { name: 'May', orders: 700 },
  { name: 'Jun', orders: 600 },
  { name: 'Jul', orders: 800 },
  { name: 'Aug', orders: 650 },
  { name: 'Sep', orders: 400 },
  { name: 'Oct', orders: 550 },
  { name: 'Nov', orders: 300 },
  { name: 'Dec', orders: 750 },
];

const getPath = (x, y, width, height) => {
  return `M${x},${y + height}C${x + width / 3},${y + height} ${x + width / 2},${y + height / 3}
  ${x + width / 2}, ${y}
  C${x + width / 2},${y + height / 3} ${x + (2 * width) / 3},${y + height} ${x + width}, ${y + height}
  Z`;
};

const TriangleBar = ({ fill, x, y, width, height }) => (
  <path d={getPath(x, y, width, height)} stroke="none" fill={fill} />
);

const OrdersBarChart = () => {
  const { isDarkMode,theme } = useTheme();

  
  const colors = [
    theme.primary
  
  ];

  const handleBarClick = (data) => {
    alert(`Month: ${data.name}, Orders: ${data.orders}`);
  };

  return (
    <ResponsiveContainer width="100%" height="100%">
      <BarChart
        data={data}
        margin={{
          top: 20,
          right: 10,
          left: 10,
          bottom: 5,
        }}
      >
        <CartesianGrid strokeDasharray="3 3" stroke={isDarkMode ? '#555' : '#ccc'} />
        <XAxis dataKey="name" stroke={isDarkMode ? '#fff' : '#000'} />
        <YAxis stroke={isDarkMode ? '#fff' : '#000'} />
        <Tooltip contentStyle={{ backgroundColor: isDarkMode ? '#333' : '#fff', color: isDarkMode ? '#fff' : '#000', }} />
        <Bar
          dataKey="orders"
          shape={<TriangleBar />}
          label={{ position: 'top', fill: isDarkMode ? '#fff' : '#000' }}
          onClick={(data) => handleBarClick(data)}
        >
          {data.map((entry, index) => (
            <Cell key={`cell-${index}`} fill={colors[index % colors.length]} />
          ))}
        </Bar>
      </BarChart>
    </ResponsiveContainer>
  );
};

export default OrdersBarChart;
