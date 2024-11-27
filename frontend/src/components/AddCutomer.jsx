import React, { useState } from "react";
import styled from "styled-components";

// Styled Components
const ModalOverlay = styled.div`
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  background-color: rgba(0, 0, 0, 0.5);
  display: flex;
  justify-content: center;
  align-items: center;
  z-index: 999;
`;

const ModalContainer = styled.div`
  background-color: ${({ theme }) => theme.background || "#ffffff"};
  color: ${({ theme }) => theme.text || "#000000"};
  padding: 20px;
  border-radius: 10px;
  width: 400px;
  box-shadow: 0 5px 15px rgba(0, 0, 0, 0.3);
`;

const ModalHeader = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
`;

const Title = styled.h2`
  font-size: 1.5rem;
`;

const CloseButton = styled.button`
  background: none;
  border: none;
  font-size: 1.2rem;
  font-weight: bold;
  cursor: pointer;
  color: ${({ theme }) => theme.accent || "#6a00ff"};

  &:hover {
    color: ${({ theme }) => theme.accentHover || "#5200cc"};
  }
`;

const Form = styled.form`
  display: flex;
  flex-direction: column;
  gap: 15px;
`;

const InputField = styled.input`
  padding: 10px;
  border: 1px solid ${({ theme }) => theme.border || "#cccccc"};
  border-radius: 5px;
  background-color: ${({ theme }) => theme.inputBackground || "#f9f9f9"};
  color: ${({ theme }) => theme.text || "#000000"};

  &:focus {
    outline: none;
    border-color: ${({ theme }) => theme.accent || "#6a00ff"};
  }
`;

const Label = styled.label`
  font-size: 0.9rem;
`;

const PhotoUpload = styled.div`
  display: flex;
  flex-direction: column;
  gap: 5px;

  input {
    padding: 5px;
  }
`;

const DateInput = styled(InputField).attrs({ type: "date" })``;

const SubmitButton = styled.button`
  padding: 10px;
  background-color: ${({ theme }) => theme.accent || "#6a00ff"};
  color: white;
  font-size: 1rem;
  border: none;
  border-radius: 5px;
  cursor: pointer;

  &:hover {
    background-color: ${({ theme }) => theme.accentHover || "#5200cc"};
  }
`;

const CancelButton = styled.button`
  padding: 10px;
  background-color: ${({ theme }) => theme.cancelBackground || "#cccccc"};
  color: ${({ theme }) => theme.text || "#000000"};
  font-size: 1rem;
  border: none;
  border-radius: 5px;
  cursor: pointer;

  &:hover {
    background-color: ${({ theme }) => theme.cancelHover || "#aaaaaa"};
  }
`;

// Modal Component
const AddCustomer = ({ isOpen, onClose, onSubmit, theme }) => {
  const [formData, setFormData] = useState({
    name: "",
    email: "",
    contact: "",
    city: "",
    country: "",
    street: "",
    dob: "",
    photo: null,
  });

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handlePhotoChange = (e) => {
    setFormData((prev) => ({ ...prev, photo: e.target.files[0] }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    onSubmit(formData); // Pass form data to parent
    onClose(); // Close the modal
  };

  if (!isOpen) return null;

  return (
    <ModalOverlay>
      <ModalContainer theme={theme}>
        <ModalHeader>
          <Title>Add Customer</Title>
          <CloseButton onClick={onClose}>&times;</CloseButton>
        </ModalHeader>
        <Form onSubmit={handleSubmit}>
          {/* Name */}
          <Label htmlFor="name">Name</Label>
          <InputField
            id="name"
            name="name"
            type="text"
            placeholder="Enter customer's name"
            value={formData.name}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Email */}
          <Label htmlFor="email">Email</Label>
          <InputField
            id="email"
            name="email"
            type="email"
            placeholder="Enter customer's email"
            value={formData.email}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Contact */}
          <Label htmlFor="contact">Contact</Label>
          <InputField
            id="contact"
            name="contact"
            type="tel"
            placeholder="Enter contact number"
            value={formData.contact}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* City */}
          <Label htmlFor="city">City</Label>
          <InputField
            id="city"
            name="city"
            type="text"
            placeholder="Enter city"
            value={formData.city}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Country */}
          <Label htmlFor="country">Country</Label>
          <InputField
            id="country"
            name="country"
            type="text"
            placeholder="Enter country"
            value={formData.country}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Street */}
          <Label htmlFor="street">Street</Label>
          <InputField
            id="street"
            name="street"
            type="text"
            placeholder="Enter street"
            value={formData.street}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Date of Birth */}
          <Label htmlFor="dob">Date of Birth</Label>
          <DateInput
            id="dob"
            name="dob"
            value={formData.dob}
            onChange={handleInputChange}
            theme={theme}
          />

          {/* Photo */}
          <PhotoUpload>
            <Label htmlFor="photo">Photo</Label>
            <input
              id="photo"
              name="photo"
              type="file"
              accept="image/*"
              onChange={handlePhotoChange}
              theme={theme}
            />
          </PhotoUpload>

          {/* Buttons */}
          <div style={{ display: "flex", gap: "10px" }}>
            <SubmitButton type="submit" theme={theme}>
              Submit
            </SubmitButton>
            <CancelButton type="button" onClick={onClose} theme={theme}>
              Cancel
            </CancelButton>
          </div>
        </Form>
      </ModalContainer>
    </ModalOverlay>
  );
};

export default AddCustomer;
