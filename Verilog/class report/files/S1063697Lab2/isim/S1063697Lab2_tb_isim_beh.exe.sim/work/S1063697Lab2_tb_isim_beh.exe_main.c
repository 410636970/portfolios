/**********************************************************************/
/*   ____  ____                                                       */
/*  /   /\/   /                                                       */
/* /___/  \  /                                                        */
/* \   \   \/                                                       */
/*  \   \        Copyright (c) 2003-2009 Xilinx, Inc.                */
/*  /   /          All Right Reserved.                                 */
/* /---/   /\                                                         */
/* \   \  /  \                                                      */
/*  \___\/\___\                                                    */
/***********************************************************************/

#include "xsi.h"

struct XSI_INFO xsi_info;



int main(int argc, char **argv)
{
    xsi_init_design(argc, argv);
    xsi_register_info(&xsi_info);

    xsi_register_min_prec_unit(-12);
    work_m_00000000001092834986_3068324535_init();
    work_m_00000000000180908537_2513369863_init();
    work_m_00000000000877949286_2993657349_init();
    work_m_00000000003293902329_1704821491_init();
    work_m_00000000001777028657_2935711662_init();
    work_m_00000000004134447467_2073120511_init();


    xsi_register_tops("work_m_00000000001777028657_2935711662");
    xsi_register_tops("work_m_00000000004134447467_2073120511");


    return xsi_run_simulation(argc, argv);

}