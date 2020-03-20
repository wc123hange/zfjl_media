using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void update_delegate(string str);
        private void update(string str)
        {
            this.textBox1.Text += str + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var uptModel = DBContext.media_context.From<pe_video_list>().Where(d => d.id > 1000).Page(10,2).ToList();
            BlockingCollection<pe_video_list_del> list1 = new BlockingCollection<pe_video_list_del>();
            BlockingCollection<pe_video_list_del> list2 = new BlockingCollection<pe_video_list_del>();
            BlockingCollection<pe_video_list_del> list3 = new BlockingCollection<pe_video_list_del>();

            for (int i = 0; i < 100; i++)
            {
                list1.Add(new pe_video_list_del()
                {
                    pfilename = "线程1" + i.ToString(),
                    filename = "线程1" + i.ToString(),
                    creater = "线程1" + i.ToString()

                });

            }
            for (int i = 0; i < 100; i++)
            {
                list2.Add(new pe_video_list_del()
                {
                    pfilename = "线程2" + i.ToString(),
                    filename = "线程2" + i.ToString(),
                    creater = "线程2" + i.ToString()

                });
            }
            for (int i = 0; i < 100; i++)
            {
                list3.Add(new pe_video_list_del()
                {
                    pfilename = "线程3" + i.ToString(),
                    filename = "线程3" + i.ToString(),
                    creater = "线程3" + i.ToString()

                });
            }
            var t = Task.Run(() =>
            {
                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.AttachedToParent);
                var childTasks = new Task[]
                {
                    tf.StartNew(()=>{
                        doinsert(list1);
                      }),
                    tf.StartNew(()=>{
                        doinsert(list2);}),
                    tf.StartNew(()=>{
                    doinsert(list3);
                    })
                };
            });
        }

        private void doinsert(BlockingCollection<pe_video_list_del> list)
        {
            Parallel.ForEach(list, model =>
            {
                int result = DBContext.media_context.Insert<pe_video_list_del>(model);
                this.Invoke(new update_delegate(update), model.filename);
            });

        }
    }
}
