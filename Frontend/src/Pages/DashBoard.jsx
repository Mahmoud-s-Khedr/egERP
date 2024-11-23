import { Container, Row, Col, Table } from 'react-bootstrap'
import MainBarCharts from '../Components/Charts/MainBarCharts'
import DashBoardCard from '../Components/Cards/DashBoardCard'
import FirstTable from '../Components/Tables/DashboardTable'
import DashboardTable from '../Components/Tables/DashboardTable';
import DashBoardPieChart from '../Components/Charts/DashBoardPieChart';

function DashBoard() {
  
    return (
      <div className="p-2 dashboard ">
        <Row className='m-0' >
      <div className="chart-container p-0 col-12 col-lg-8 ">
        <MainBarCharts  />
      </div>
      <div className="col-12 col-md-4 d-flex flex-wrap p-0 align-content-between justify-content-center">
        <DashBoardCard totalCustomers={1000}/>
        <DashBoardCard totalCustomers={1000}/>
      </div>
      </Row>
      <Row className='mt-4 mx-0 col-12 gap-2'>
        <Col className='p-0 col-12 col-lg-6 '>
        <DashboardTable />
        </Col>
         <Col className='p-0  d-lg-flex border-0 justify-content-center card  '>
           <DashBoardPieChart className="col-lg-6 "/>
        </Col>
        
      </Row>
      </div>
    )
};

export default DashBoard