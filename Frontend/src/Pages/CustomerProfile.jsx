import { Row } from "react-bootstrap";
import ProfileCard from "../Components/Cards/ProfileCard";

function CustomerProfile() {
    return (
        <div className="col-12">
            <Row>
                <ProfileCard/>
            </Row>
        </div>
    )
}

export default CustomerProfile;