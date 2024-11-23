import Pagination from 'react-bootstrap/Pagination';

function AdvancedExample() {
  return (
    <Pagination className='m-0 d-flex p-1  flex-row-reverse'>
      <Pagination.First />
      <Pagination.Item>{1}</Pagination.Item>
      <Pagination.Item>{2}</Pagination.Item>
      <Pagination.Item>{3}</Pagination.Item>
      <Pagination.Ellipsis />

      <Pagination.Item>{10}</Pagination.Item>
      
      
      <Pagination.Item>{20}</Pagination.Item>
      <Pagination.Next />
      
    </Pagination>
  );
}

export default AdvancedExample;