import React, { useState } from 'react';
import { Form, Button, Row, Col } from 'react-bootstrap';

const CustomerSearchForm = () => {
  const [searchBy, setSearchBy] = useState('');
  const [searchInput, setSearchInput] = useState('');

  const handleSearch = (e) => {
    e.preventDefault();
    if (searchBy && searchInput) {
      alert(`Searching for "${searchInput}" by "${searchBy}"`);
      // Add your search logic here
    } else {
      alert('Please select a search criteria and enter a search term.');
    }
  };

  return (
    <Form onSubmit={handleSearch} className="mt-2 customer-search-form mt-lg-0">
      <Row className="align-items-center">
        {/* Select Dropdown */}
        <Col  className=" mp-0">
          <Form.Select
            value={searchBy}
            onChange={(e) => setSearchBy(e.target.value)}
            required
          >
            <option value="" disabled>
              Search By
            </option>
            <option value="name">Name</option>
            <option value="email">Email</option>
            <option value="id">ID</option>
          </Form.Select>
        </Col>

        {/* Input Field */}
        <Col  className=" p-0">
          <Form.Control
            type="text"
            placeholder="Search..."
            value={searchInput}
            onChange={(e) => setSearchInput(e.target.value)}
            required
          />
        </Col>

        {/* Submit Button */}
        <Col>
          <Button type="submit" className="w-100">
            Search
          </Button>
        </Col>
      </Row>
    </Form>
  );
};

export default CustomerSearchForm;
