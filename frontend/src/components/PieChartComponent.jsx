import { PieChart, Pie, Legend, Tooltip, ResponsiveContainer, Cell } from 'recharts';
import { useTheme } from '../context/Theme';
import { BiColor } from 'react-icons/bi';
// Sample customer data with country field
const customers = [
  { name: 'John Doe', country: 'USA' },
  { name: 'Jane Smith', country: 'Canada' },
  { name: 'Sam Wilson', country: 'USA' },
  { name: 'Lisa Brown', country: 'UK' },
  { name: 'Tom Harris', country: 'Canada' },
  { name: 'Emily Johnson', country: 'Australia' },
  { name: 'Chris Lee', country: 'USA' },
  { name: 'Patricia Taylor', country: 'UK' },
];

// Function to count customers per country
const getCountryData = (customers) => {
  const countryCounts = customers.reduce((acc, customer) => {
    acc[customer.country] = (acc[customer.country] || 0) + 1;
    return acc;
  }, {});

  return Object.keys(countryCounts).map((country) => ({
    name: country,
    value: countryCounts[country],
  }));
};

const data = getCountryData(customers); // Get customer count per country

export default function PieChartComponent() {

  function renderCustomizedLabel  ({ name, value, cx, cy, midAngle, innerRadius, outerRadius, percent })  {
    // Calculate the angle for placing the label
    const RADIAN = Math.PI / 180;
    const radius = 15 + innerRadius + (outerRadius - innerRadius) / 2; // Adjusting label position
    const x = cx + radius * Math.cos(-midAngle * RADIAN);
    const y = cy + radius * Math.sin(-midAngle * RADIAN);

    return (
      <text x={x} y={y} fill="#fff" textAnchor="middle" dominantBaseline="middle" fontSize={12}>
        {`${name}: ${value}`}
      </text>
    );
  };

    const {theme} = useTheme();
    const color = [
      theme.primary,
      theme.secondary,
      theme.red,
      theme.yellow
    ]
    return (
      <ResponsiveContainer width="100%" height="100%">
        <PieChart width="100%" height="100%">
          <Pie
            dataKey="value"
            isAnimationActive={false}
            data={data}
            cx="50%"
            cy="50%"
            outerRadius={120}
            fill="#2f60e6"
            labelLine={false} // Turn off the line connecting label and pie slice
            label={renderCustomizedLabel} // Custom label to show the number of customers per country
          >
            {data.map((entry, index) => (
              <Cell key={`cell-${index}`} fill={Math.random() > 0.5 ? color[index % color.length] : color[index % color.length]} />
            ))}
          </Pie>
          <Tooltip />
          <Legend />
        </PieChart>
      </ResponsiveContainer>
    );
  }
