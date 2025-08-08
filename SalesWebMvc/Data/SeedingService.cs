using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");


            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Alice Smith", "alice.smith@example.com", new DateTime(1995, 11, 12), 1200.0, d2);
            Seller s3 = new Seller(3, "Carlos Mendes", "carlos.mendes@example.com", new DateTime(1990, 2, 5), 1500.0, d1);
            Seller s4 = new Seller(4, "Diana Lee", "diana.lee@example.com", new DateTime(1988, 9, 30), 1100.0, d3);
            Seller s5 = new Seller(5, "Ethan Clark", "ethan.clark@example.com", new DateTime(1992, 7, 19), 1400.0, d2);
            Seller s6 = new Seller(6, "Fernanda Souza", "fernanda.souza@example.com", new DateTime(1997, 3, 3), 1300.0, d1);
            Seller s7 = new Seller(7, "George Silva", "george.silva@example.com", new DateTime(1991, 6, 25), 1150.0, d3);
            Seller s8 = new Seller(8, "Hanna Müller", "hanna.muller@example.com", new DateTime(1996, 12, 1), 1250.0, d2);
            Seller s9 = new Seller(9, "Igor Costa", "igor.costa@example.com", new DateTime(1994, 8, 15), 1450.0, d1);
            Seller s10 = new Seller(10, "Julia Ramos", "julia.ramos@example.com", new DateTime(1993, 5, 10), 1350.0, d3);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2025, 06, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2025, 06, 26), 8500.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2025, 06, 27), 9800.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2025, 06, 28), 10200.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2025, 06, 29), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2025, 07, 01), 7300.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2025, 07, 02), 6500.0, SaleStatus.Billed, s7);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2025, 07, 03), 8900.0, SaleStatus.Billed, s8);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2025, 07, 04), 9600.0, SaleStatus.Billed, s9);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2025, 07, 05), 11400.0, SaleStatus.Billed, s10);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2025, 07, 06), 8200.0, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2025, 07, 07), 9100.0, SaleStatus.Billed, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2025, 07, 08), 10100.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2025, 07, 09), 10750.0, SaleStatus.Billed, s4);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2025, 07, 10), 8900.0, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2025, 07, 11), 7500.0, SaleStatus.Billed, s6);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2025, 07, 12), 9300.0, SaleStatus.Billed, s7);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2025, 07, 13), 9950.0, SaleStatus.Billed, s8);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2025, 07, 14), 8800.0, SaleStatus.Billed, s9);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2025, 07, 15), 10500.0, SaleStatus.Billed, s10);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2025, 07, 16), 9200.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2025, 07, 17), 9700.0, SaleStatus.Billed, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2025, 07, 18), 10000.0, SaleStatus.Billed, s3);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2025, 07, 19), 11300.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2025, 07, 20), 8700.0, SaleStatus.Billed, s5);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2025, 07, 21), 9400.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2025, 07, 22), 10900.0, SaleStatus.Billed, s7);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2025, 07, 23), 9700.0, SaleStatus.Billed, s8);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2025, 07, 24), 10250.0, SaleStatus.Billed, s9);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2025, 07, 25), 11800.0, SaleStatus.Billed, s10);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                                            r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                                            r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
