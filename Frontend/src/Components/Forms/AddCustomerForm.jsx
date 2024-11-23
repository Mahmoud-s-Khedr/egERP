import React, { useState } from 'react';
import { Form, Button, Modal, Row, Col, Image } from 'react-bootstrap';
import { useTheme } from '../../Context/ThemeContext';
function AddCustomerForm  ({ show, handleClose, handleSave })  {
  const {theme} = useTheme();
  const [customer, setCustomer] = useState({
    firstName: '',
    lastName: '',
    dateOfBirth: '',
    gender: '',
    email: '',
    phone: '',
    address: {
      country: '',
      city: '',
      street: '',
    },
    profileImage: null, // Holds the uploaded image file
  });

  const [imagePreview, setImagePreview] = useState(null); // Holds the image preview URL

  const handleChange = (e) => {
    const { name, value } = e.target;

    if (name.startsWith('address.')) {
      const field = name.split('.')[1];
      setCustomer((prev) => ({
        ...prev,
        address: {
          ...prev.address,
          [field]: value,
        },
      }));
    } else {
      setCustomer({ ...customer, [name]: value });
    }
  };

  const handleImageChange = (e) => {
    const file = e.target.files[0];
    if (file) {
      setCustomer((prev) => ({ ...prev, profileImage: file }));
      setImagePreview(URL.createObjectURL(file)); // Generate a preview URL
    }
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Handle form submission with the image
    const formData = new FormData();
    formData.append('firstName', customer.firstName);
    formData.append('lastName', customer.lastName);
    formData.append('dateOfBirth', customer.dateOfBirth);
    formData.append('gender', customer.gender);
    formData.append('email', customer.email);
    formData.append('phone', customer.phone);
    formData.append('address[country]', customer.address.country);
    formData.append('address[city]', customer.address.city);
    formData.append('address[street]', customer.address.street);
    if (customer.profileImage) {
      formData.append('profileImage', customer.profileImage);
    }

    handleSave(formData); // Pass the FormData object
    setCustomer({
      firstName: '',
      lastName: '',
      dateOfBirth: '',
      gender: '',
      email: '',
      phone: '',
      address: {
        country: '',
        city: '',
        street: '',
      },
      profileImage: null,
    });
    setImagePreview(null);
    handleClose();
  };

  return (
    <Modal show={show} className={theme ? 'add-customer-form-dark' : ''} onHide={handleClose}>
      <Modal.Header closeButton >
        <Modal.Title>Add Customer</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form onSubmit={handleSubmit}>
          {/* Personal Details */}
          <Row className="mb-3">
            <Col>
              <Form.Group controlId="formFirstName">
                <Form.Label>First Name</Form.Label>
                <Form.Control
                  type="text"
                  name="firstName"
                  value={customer.firstName}
                  onChange={handleChange}
                  placeholder="Enter first name"
                  required
                />
              </Form.Group>
            </Col>
            <Col>
              <Form.Group controlId="formLastName">
                <Form.Label>Last Name</Form.Label>
                <Form.Control
                  type="text"
                  name="lastName"
                  value={customer.lastName}
                  onChange={handleChange}
                  placeholder="Enter last name"
                  required
                />
              </Form.Group>
            </Col>
          </Row>

          <Form.Group className="mb-3" controlId="formDateOfBirth">
            <Form.Label>Date of Birth</Form.Label>
            <Form.Control
              type="date"
              name="dateOfBirth"
              value={customer.dateOfBirth}
              onChange={handleChange}
              required
            />
          </Form.Group>

          <Form.Group className="mb-3" controlId="formGender">
            <Form.Label>Gender</Form.Label>
            <Form.Select
              name="gender"
              value={customer.gender}
              onChange={handleChange}
              required
            >
              <option value="">Select gender</option>
              <option value="Male">Male</option>
              <option value="Female">Female</option>
              <option value="Other">Other</option>
            </Form.Select>
          </Form.Group>

          {/* Contact Information */}
          <Form.Group className="mb-3" controlId="formEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control
              type="email"
              name="email"
              value={customer.email}
              onChange={handleChange}
              placeholder="Enter email"
              required
            />
          </Form.Group>

          <Form.Group className="mb-3" controlId="formPhone">
            <Form.Label>Phone</Form.Label>
            <Form.Control
              type="text"
              name="phone"
              value={customer.phone}
              onChange={handleChange}
              placeholder="Enter phone number"
              required
            />
          </Form.Group>

          {/* Address */}
          <Form.Group className="mb-3" controlId="formCountry">
            <Form.Label>Country</Form.Label>
            <Form.Control
              type="text"
              name="address.country"
              value={customer.address.country}
              onChange={handleChange}
              placeholder="Enter country"
              required
            />
          </Form.Group>

          <Row className="mb-3">
            <Col>
              <Form.Group controlId="formCity">
                <Form.Label>City</Form.Label>
                <Form.Control
                  type="text"
                  name="address.city"
                  value={customer.address.city}
                  onChange={handleChange}
                  placeholder="Enter city"
                  required
                />
              </Form.Group>
            </Col>
            <Col>
              <Form.Group controlId="formStreet">
                <Form.Label>Street</Form.Label>
                <Form.Control
                  type="text"
                  name="address.street"
                  value={customer.address.street}
                  onChange={handleChange}
                  placeholder="Enter street"
                  required
                />
              </Form.Group>
            </Col>
          </Row>

          {/* Image Upload */}
          <Form.Group className="mb-3" controlId="formProfileImage">
            <Form.Label>Profile Image</Form.Label>
            <Form.Control
              type="file"
              accept="image/*"
              onChange={handleImageChange}
            />
            {imagePreview && (
              <div className="mt-3">
                <Image src={imagePreview} alt="Profile Preview" rounded fluid />
              </div>
            )}
          </Form.Group>

          <Button variant="primary" type="submit">
            Save Customer
          </Button>
        </Form>
      </Modal.Body>
    </Modal>
  );
};

export default AddCustomerForm;

