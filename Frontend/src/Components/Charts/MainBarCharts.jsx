import React, { useEffect, useRef, useState } from 'react';
import { BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid, Tooltip } from 'recharts';
import { useTheme } from '../../Context/ThemeContext';

const lightColors = ['#4CAF50', '#2196F3', '#FFC107', '#FF5722', '#9C27B0', '#00BCD4', '#CDDC39', '#673AB7', '#FFEB3B', '#795548', '#607D8B', '#E91E63'];
const darkColors = ['#81C784', '#64B5F6', '#FFD54F', '#FF8A65', '#BA68C8', '#4DD0E1', '#DCE775', '#9575CD', '#FFF176', '#A1887F', '#90A4AE', '#F06292'];

const data = [
  { name: 'January', orders: 400 },
  { name: 'February', orders: 300 },
  { name: 'March', orders: 500 },
  { name: 'April', orders: 200 },
  { name: 'May', orders: 450 },
  { name: 'June', orders: 600 },
  { name: 'July', orders: 350 },
  { name: 'August', orders: 400 },
  { name: 'September', orders: 420 },
  { name: 'October', orders: 480 },
  { name: 'November', orders: 530 },
  { name: 'December', orders: 620 },
];

const getPath = (x, y, width, height) => {
  return `M${x},${y + height}C${x + width / 3},${y + height} ${x + width / 2},${y + height / 3}
  ${x + width / 2}, ${y}
  C${x + width / 2},${y + height / 3} ${x + (2 * width) / 3},${y + height} ${x + width}, ${y + height}
  Z`;
};

const TriangleBar = (props) => {
  const { fill, x, y, width, height } = props;
  return <path d={getPath(x, y, width, height)} stroke="none" fill={fill} />;
};

export default function App() {
  const [width, setWidth] = useState(800);
  const containerRef = useRef(null);
  const {theme} = useTheme();
  useEffect(() => {
    const updateWidth = () => {
      if (containerRef.current) {
        setWidth(containerRef.current.offsetWidth);
      }
    };
    updateWidth();
    window.addEventListener('resize', updateWidth);
    return () => window.removeEventListener('resize', updateWidth);
  }, []);



  const colors = theme ? darkColors : lightColors;

  return (
    <div
      ref={containerRef}
      className='main-bar-charts shadow-sm'
    >
      <header className='fw-semibold ms-4 mt-1'>Ordres Statistics</header>
      {width > 0 && (
        <BarChart
          width={width*.8}
          height={330}
          data={data}
          margin={{
            top: 20,
            right: 50,
            left: 10,
            bottom: 5,
          }}
        >
          <CartesianGrid strokeDasharray="3 3" stroke={theme ? '#555555' : '#E0E0E0'} />
          <XAxis dataKey="name" stroke={theme ? '#FFFFFF' : '#000000'} />
          <YAxis stroke={theme ? '#FFFFFF' : '#000000'} />
          <Tooltip
            contentStyle={{
              backgroundColor: theme ? '#333333' : '#FFFFFF',
              color: theme ? '#FFFFFF' : '#000000',
            }}
          />
          <Bar dataKey="orders" shape={<TriangleBar />} label={{ position: 'top' }}>
            {data.map((entry, index) => (
              <Cell key={`cell-${index}`} fill={colors[index % colors.length]} />
            ))}
          </Bar>
        </BarChart>
      )}
    </div>
  );
}
