import { faJ } from '@fortawesome/free-solid-svg-icons';
import React from 'react';
import { Table, Image, Button } from 'react-bootstrap';

function DashboardTable() {
  // Dummy data for top 5 spending customers
  const topCustomers = [
    {
      id: 1,
      profilePic: 'https://via.placeholder.com/50',
      name: 'John Doe',
      numOrders: 45,
      totalSpend: 2300.0,
    },
    {
      id: 2,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Jane Smith',
      numOrders: 32,
      totalSpend: 1850.5,
    },
    {
      id: 3,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Emily Johnson',
      numOrders: 29,
      totalSpend: 1625.75,
    },
    {
      id: 4,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Michael Brown',
      numOrders: 22,
      totalSpend: 1450.0,
    },
    {
      id: 5,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Chris Davis',
      numOrders: 19,
      totalSpend: 1299.99,
    },

    {
      id: 1,
      profilePic: 'https://via.placeholder.com/50',
      name: 'John Doe',
      numOrders: 45,
      totalSpend: 2300.0,
    },
    {
      id: 2,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Jane Smith',
      numOrders: 32,
      totalSpend: 1850.5,
    },
    {
      id: 3,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Emily Johnson',
      numOrders: 29,
      totalSpend: 1625.75,
    },
    {
      id: 4,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Michael Brown',
      numOrders: 22,
      totalSpend: 1450.0,
    },
    {
      id: 5,
      profilePic: 'https://via.placeholder.com/50',
      name: 'Chris Davis',
      numOrders: 19,
      totalSpend: 1299.99,
    },
  ];

  return (
    <div className="dashboard-table-container">
      <Table bordered hover responsive className="dashboard-table">
        <thead>
          <tr>
            <th>Profile & Name</th>
            <th>Orders</th>
            <th>Total Spend</th>
            <th >Actions</th>
          </tr>
        </thead>
        <tbody>
          {topCustomers.map((customer) => (
            <tr key={customer.id}>
              <td>
                <div className="d-lg-flex align-items-center ms-0 ms-lg-4 my-">
                  <Image
                    
                    className='me-lg-2 '
                    src={customer.profilePic}
                    alt={`${customer.name}'s profile`}
                    roundedCircle
                    style={{ width: '60px', height: '60px'}}
                  />
                  <span>{customer.name}</span>
                </div>
              </td>
              <td>{customer.numOrders}</td>
              <td>${customer.totalSpend.toFixed(2)}</td>
              <td >
                <Button
                  className="fw-semibold btn-success"
                  size="sm"
                  onClick={() => alert(`Showing profile for ${customer.name}`)}
                >
                  Show Profile
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
}

export default DashboardTable;
