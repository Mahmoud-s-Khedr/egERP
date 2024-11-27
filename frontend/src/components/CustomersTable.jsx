import React from 'react';
import styled from 'styled-components';

const TableContainer = styled.div`
  width: 100%;
  
`;

const Table = styled.div`
  display: flex;
  flex-direction: column;
  width: 100%;
`;

const TableHeaderRow = styled.div`
  display: flex;
  background-color:${({theme})=>theme.componentBackground};
  color: ${({theme})=>theme.text};
  border-bottom: 2px solid #3498db;
  padding: 5px 5px;

`;

const TableRow = styled.div`
  display: flex;
  padding: 5px 5px;
  border-bottom: 1px solid #ddd;
  &:nth-child(even) {
    background-color: ${({theme})=>theme.componentBackground};
    color: ${({theme})=>theme.text};
  }
`;

const TableCell = styled.div`
  flex: 1;
  color: ${({theme})=>theme.text};
  background-color: ${({theme})=>theme.componentBackground};
  font-size: 14px;
  text-align: center;
  vertical-align: middle;


  &:nth-child(5) {
    text-align: center;
  }
  @media (max-width: 768px) {
    font-size: 10px;
  }
`;

const Button = styled.button`
  padding: 4px 6px;
  border: none;
  border-radius: 4px;
  background-color: ${({theme})=>theme.primary};
  color: white;
  cursor: pointer;
  font-size: 14px;
  transition: all 0.3s ease;

  &:hover {
    background-color: #2980b9;
  }
`;

const CustomerTable = () => {
  const customers = [
    { name: 'John Doe', email: 'john@example.com', totalSpend: 1234.56, totalOrders: 15 },
    { name: 'Jane Smith', email: 'jane@example.com', totalSpend: 890.12, totalOrders: 8 },
    { name: 'Sam Wilson', email: 'sam@example.com', totalSpend: 450.5, totalOrders: 5 },
    { name: 'Lisa Brown', email: 'lisa@example.com', totalSpend: 1200.99, totalOrders: 18 },
    { name: 'Tom Harris', email: 'tom@example.com', totalSpend: 780.75, totalOrders: 12 },
  ];

  return (
    <TableContainer>
      <Table>
        {/* Table Header */}
        <TableHeaderRow>
          <TableCell><strong>Customer Name</strong></TableCell>
          <TableCell><strong>Customer Email</strong></TableCell>
          <TableCell><strong>Total Spend</strong></TableCell>
          <TableCell><strong>Total Orders</strong></TableCell>
          <TableCell><strong>Action</strong></TableCell>
        </TableHeaderRow>

        {/* Table Rows */}
        {customers.map((customer, index) => (
          <TableRow key={index}>
            <TableCell>{customer.name}</TableCell>
            <TableCell>{customer.email}</TableCell>
            <TableCell>${customer.totalSpend.toFixed(2)}</TableCell>
            <TableCell>{customer.totalOrders}</TableCell>
            <TableCell>
              <Button onClick={() => alert(`Viewing ${customer.name}'s profile`)}>
                 Profile
              </Button>
            </TableCell>
          </TableRow>
        ))}
      </Table>
    </TableContainer>
  );
};

export default CustomerTable;
