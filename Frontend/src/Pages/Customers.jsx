import { Button, Col, Row } from "react-bootstrap";
import DashboardTable from "../Components/Tables/DashboardTable";
import DropDownComponent from "../Components/DropDown/DropDownComponent";
import Paginate from "../Components/Pagination/Paginate";
import CustomerSearchForm from "../Components/Forms/CustomerSearchForm";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faPlus } from "@fortawesome/free-solid-svg-icons";
import{ useState } from "react";
import AddCustomerForm from "../Components/Forms/AddCustomerForm";
function Customers() {
    const [showAddCustomer, setShowAddCustomer] = useState(false);
    return (
        <div className="col-12">
            <Row className="card m-0 py-2 my-1 customer-page-card flex-row align-items-center ">
                <Col className="col-12 col-md-2">
                    <DropDownComponent/>
                </Col>
                <Col className="col-12 col-md-4">
                    <CustomerSearchForm/>
                </Col>
                <Col className="col-12 col-md-3">
                    <Button onClick={() => setShowAddCustomer(true)} variant="success" className="mt-2 mt-md-0">Add Customer<FontAwesomeIcon className="ms-2" icon={faPlus} /></Button> 
                </Col>
            </Row>
            <Row>
                <AddCustomerForm show={showAddCustomer} handleClose={() => {setShowAddCustomer(false)}} handleSave={() => {}}/>
            </Row>
            <Row className="mt-2 px-0 py-2">
                <DashboardTable/>
            </Row>
            <Row className="mt-2 w-100 justify-content-center px-2 card mx-0">
                <Col className="p-0">
                <Paginate/>
                </Col>
            </Row>
        </div>
    )
}

export default Customers;