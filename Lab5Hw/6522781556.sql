select b.title, concat(a.first_name,'',a.last_name) as author_name 
from transactions t
join books b on t.book_id = b.book_id
join authors a on b.author_id = a.author_id 
join borrowers br on t.borrower_id = br.borrower_id
where br.first_name = 'Alice' and br.last_name = 'Johnson';

select b.title as book_title,
concat(br.first_name,' ',br.last_name) as borrower_name, t.return_date
from transactions t
join books b on t.book_id = b.book_id
join borrowers br on t.borrower_id = br.borrower_id
where t.return_date < t.checkout_date;

select concat(a.first_name,' ',a.last_name) as author_name, 
count(t.book_id) as books_checked_out
from authors a
join books b on a.author_id = b.author_id
join transactions t on b.book_id = t.book_id
group by a.author_id;

select concat(br.first_name,' ',br.last_name) as borrower_name,
count(t.book_id) as books_checked_out
from borrowers br
join transactions t on br.borrower_id = t.borrower_id
group by br.borrower_id
order by books_checked_out desc
LIMIT 1;

select o.order_id, 
concat(c.first_name,' ',c.last_name) as customer_name,
sum(p.price * oi.quantity) as order_total
from orders o
join customers c on o.customer_id = c.customer_id
join order_items oi on o.order_id = oi.order_id
join products p on oi.product_id = p.product_id
group by o.order_id;

select sum(p.price * oi.quantity) as total_revenue
from order_items oi
join products p on oi.product_id = p.product_id;

create view popular_products as
select p.name as product_name, 
sum(oi.quantity) as total_quantity_sold
from order_items oi
join products p on oi.product_id = p.product_id
group by p.name
order by total_quantity_sold desc;

select concat(c.first_name,' ',c.last_name) as customer_name,
sum(p.price * oi.quantity) as total_spent
from orders o
join customers c on o.customer_id = c.customer_id
join order_items oi on o.order_id = oi.order_id
join products p on oi.product_id = p.product_id
group by c.customer_id
order by total_spent desc;

select c.customer_id,
concat(c.first_name,' ',c.last_name) as customer_name,
sum(a.balance) as total_balance
from customers c
join accounts a on c.customer_id = a.customer_id
group by c.customer_id;

select concat(c.first_name,' ',c.last_name) as customer_name,
sum(a.balance) as total_balance
from customers c
join accounts a on c.customer_id = a.customer_id
group by c.customer_id
order by total_balance desc
LIMIT 3;

update web_pages
set content = 'Under content for the web page'
where url = 'http://www.example.com/page1';

select wp.title,
wp.url,
sr.rank
from search_results sr
join web_pages wp on sr.page_id = wp.page_id
join search_queries sq on sr.query_id = sq.query_id
where sq.query = 'MySQL Tutorial'
order by sr.rank asc;