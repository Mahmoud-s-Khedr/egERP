import React from "react";
import { Card, Button, Image } from "react-bootstrap";

const ProfileCard = () => {
  // Dummy data
  const photoUrl = "https://via.placeholder.com/100";
  const name = "Jane Doe";
  const email = "jane.doe@example.com";
  const phone = "+123456789";

  return (
    <div className="profile-card-container">
      <Card className="profile-card text-center shadow">
        <Card.Body>
          <Image
            src={photoUrl}
            roundedCircle
            alt={`${name}'s profile`}
            className="profile-photo"
          />
          <Card.Title className="fs-3 mt-2">{name}</Card.Title>
          <div className="d-flex justify-content-center mt-3">
            <Button href={`mailto:${email}`} variant="primary" className="me-2">
              Send Email
            </Button>
            <Button href={`tel:${phone}`} variant="success">
              Call
            </Button>
          </div>
        </Card.Body>
      </Card>
    </div>
  );
};

export default ProfileCard;
