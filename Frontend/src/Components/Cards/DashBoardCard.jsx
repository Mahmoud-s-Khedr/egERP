import { Card } from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import {faUsers} from '@fortawesome/free-solid-svg-icons'

 function CustomerCard  ({ totalCustomers })  {
  return (
    <Card className=" shadow-sm  customer-card w-100">
      <Card.Body className='p-0'>
        <div className="d-flex align-items-center justify-content-between">
          <div>
            <h6 className=" mb-2">Total Customers</h6>
            <h2 className="mb-0 fw-bold">{totalCustomers}</h2>
            <p className="text-success mb-0">
              <small>+12% from last month</small>
            </p>
          </div>
          <div className="rounded-circle bg-primary bg-opacity-10">
            <FontAwesomeIcon icon={faUsers} size="2x" className="text-green-5" />
          </div>
        </div>
      </Card.Body>
    </Card>
  );
};

export default CustomerCard;