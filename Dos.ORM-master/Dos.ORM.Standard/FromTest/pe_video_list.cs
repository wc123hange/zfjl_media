using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Dos.ORM;

namespace FromTest
{
	/// <summary>
	/// 实体类pe_video_list。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("pe_video_list")]
	[Serializable]
	public partial class pe_video_list : Entity
	{
		#region Model
		private int _id;
		private string _filename;
		private string _pfilename;
		private string _bfilename;
		private string _createdate;
		private string _filelen;
		private string _playfilelen;
		private string _filetype;
		private string _hostname;
		private string _hostcode;
		private string _hostbody;
		private string _danwei;
		private int? _onlyread;
		private int? _safejb;
		private string _caserank;
		private string _casetopic;
		private string _note;
		private string _serverurl;
		private string _servername;
		private string _thumb;
		private string _saveposition;
		private string _playposition;
		private string _macposition;
		private string _media_play_url;
		private string _source_type;
		private int? _querys;
		private int? _downloads;
		private int? _opens;
		private string _sort;
		private int? _autodel;
		private int? _isdel;
		private string _deluser;
		private int? _deldate;
		private DateTime? _uploaddate;
		private string _creater;
		private string _moder;
		private int? _modtime;
		private string _major;
		private int? _playtime;
		private int? _hot;
		private string _filecomment;
		private string _resolution;
		private int _filetotnum;
		private int _filetottime;
		private string _vio_jdsbh;
		private int? _conn_type;
		private int? _save_date;
		private int? _is_flg;
		private string _tousu;
		private string _jianju;
		private string _sjzl;

		/// <summary>
		/// 
		/// </summary>
		[Field("id")]
		
		public int id
		{
			get { return _id; }
			set
			{
				this.OnPropertyValueChange("id");
				this._id = value;
			}
		}
		/// <summary>
		/// 文件名: 机身编号@生成日期
		/// </summary>
		[Field("filename")]
		
		public string filename
		{
			get { return _filename; }
			set
			{
				this.OnPropertyValueChange("filename");
				this._filename = value;
			}
		}
		/// <summary>
		/// 前一文件名，衔接打包文件
		/// </summary>
		[Field("pfilename")]
		
		public string pfilename
		{
			get { return _pfilename; }
			set
			{
				this.OnPropertyValueChange("pfilename");
				this._pfilename = value;
			}
		}
		/// <summary>
		/// 文件别名
		/// </summary>
		[Field("bfilename")]
		
		public string bfilename
		{
			get { return _bfilename; }
			set
			{
				this.OnPropertyValueChange("bfilename");
				this._bfilename = value;
			}
		}
		/// <summary>
		/// 建创日期
		/// </summary>
		[Field("createdate")]
		
		public string createdate
		{
			get { return _createdate; }
			set
			{
				this.OnPropertyValueChange("createdate");
				this._createdate = value;
			}
		}
		/// <summary>
		/// 文件长度
		/// </summary>
		[Field("filelen")]
		
		public string filelen
		{
			get { return _filelen; }
			set
			{
				this.OnPropertyValueChange("filelen");
				this._filelen = value;
			}
		}
		/// <summary>
		/// 文件播放长度
		/// </summary>
		[Field("playfilelen")]
		
		public string playfilelen
		{
			get { return _playfilelen; }
			set
			{
				this.OnPropertyValueChange("playfilelen");
				this._playfilelen = value;
			}
		}
		/// <summary>
		/// 文件类型
		/// </summary>
		[Field("filetype")]
		
		public string filetype
		{
			get { return _filetype; }
			set
			{
				this.OnPropertyValueChange("filetype");
				this._filetype = value;
			}
		}
		/// <summary>
		/// 机主名
		/// </summary>
		[Field("hostname")]
		
		public string hostname
		{
			get { return _hostname; }
			set
			{
				this.OnPropertyValueChange("hostname");
				this._hostname = value;
			}
		}
		/// <summary>
		/// 机主编号
		/// </summary>
		[Field("hostcode")]
		
		public string hostcode
		{
			get { return _hostcode; }
			set
			{
				this.OnPropertyValueChange("hostcode");
				this._hostcode = value;
			}
		}
		/// <summary>
		/// 机身编号
		/// </summary>
		[Field("hostbody")]
		
		public string hostbody
		{
			get { return _hostbody; }
			set
			{
				this.OnPropertyValueChange("hostbody");
				this._hostbody = value;
			}
		}
		/// <summary>
		/// 单位编号
		/// </summary>
		[Field("danwei")]
		
		public string danwei
		{
			get { return _danwei; }
			set
			{
				this.OnPropertyValueChange("danwei");
				this._danwei = value;
			}
		}
		/// <summary>
		/// 只读属性 0-读写  1-只读
		/// </summary>
		[Field("onlyread")]
		
		public int? onlyread
		{
			get { return _onlyread; }
			set
			{
				this.OnPropertyValueChange("onlyread");
				this._onlyread = value;
			}
		}
		/// <summary>
		/// 安全级别 0- 1- 2- 3- 4-
		/// </summary>
		[Field("safejb")]
		
		public int? safejb
		{
			get { return _safejb; }
			set
			{
				this.OnPropertyValueChange("safejb");
				this._safejb = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("caserank")]
		
		public string caserank
		{
			get { return _caserank; }
			set
			{
				this.OnPropertyValueChange("caserank");
				this._caserank = value;
			}
		}
		/// <summary>
		/// 案件专题编号
		/// </summary>
		[Field("casetopic")]
		
		public string casetopic
		{
			get { return _casetopic; }
			set
			{
				this.OnPropertyValueChange("casetopic");
				this._casetopic = value;
			}
		}
		/// <summary>
		/// 注备
		/// </summary>
		[Field("note")]
		
		public string note
		{
			get { return _note; }
			set
			{
				this.OnPropertyValueChange("note");
				this._note = value;
			}
		}
		/// <summary>
		/// 服务器地址
		/// </summary>
		[Field("serverurl")]
		
		public string serverurl
		{
			get { return _serverurl; }
			set
			{
				this.OnPropertyValueChange("serverurl");
				this._serverurl = value;
			}
		}
		/// <summary>
		/// 服务器名称
		/// </summary>
		[Field("servername")]
		
		public string servername
		{
			get { return _servername; }
			set
			{
				this.OnPropertyValueChange("servername");
				this._servername = value;
			}
		}
		/// <summary>
		/// 缩略图
		/// </summary>
		[Field("thumb")]
		
		public string thumb
		{
			get { return _thumb; }
			set
			{
				this.OnPropertyValueChange("thumb");
				this._thumb = value;
			}
		}
		/// <summary>
		/// 存储位置
		/// </summary>
		[Field("saveposition")]
		
		public string saveposition
		{
			get { return _saveposition; }
			set
			{
				this.OnPropertyValueChange("saveposition");
				this._saveposition = value;
			}
		}
		/// <summary>
		/// 播放位置
		/// </summary>
		[Field("playposition")]
		
		public string playposition
		{
			get { return _playposition; }
			set
			{
				this.OnPropertyValueChange("playposition");
				this._playposition = value;
			}
		}
		/// <summary>
		/// 存储的物理路径
		/// </summary>
		[Field("macposition")]
		
		public string macposition
		{
			get { return _macposition; }
			set
			{
				this.OnPropertyValueChange("macposition");
				this._macposition = value;
			}
		}
		/// <summary>
		/// 播放位置
		/// </summary>
		[Field("media_play_url")]
		
		public string media_play_url
		{
			get { return _media_play_url; }
			set
			{
				this.OnPropertyValueChange("media_play_url");
				this._media_play_url = value;
			}
		}
		/// <summary>
		/// 判断播放位置
		/// </summary>
		[Field("source_type")]
		
		public string source_type
		{
			get { return _source_type; }
			set
			{
				this.OnPropertyValueChange("source_type");
				this._source_type = value;
			}
		}
		/// <summary>
		/// 查询次数
		/// </summary>
		[Field("querys")]
		
		public int? querys
		{
			get { return _querys; }
			set
			{
				this.OnPropertyValueChange("querys");
				this._querys = value;
			}
		}
		/// <summary>
		/// 下载次数
		/// </summary>
		[Field("downloads")]
		
		public int? downloads
		{
			get { return _downloads; }
			set
			{
				this.OnPropertyValueChange("downloads");
				this._downloads = value;
			}
		}
		/// <summary>
		/// 播点次数
		/// </summary>
		[Field("opens")]
		
		public int? opens
		{
			get { return _opens; }
			set
			{
				this.OnPropertyValueChange("opens");
				this._opens = value;
			}
		}
		/// <summary>
		/// 分类
		/// </summary>
		[Field("sort")]
		
		public string sort
		{
			get { return _sort; }
			set
			{
				this.OnPropertyValueChange("sort");
				this._sort = value;
			}
		}
		/// <summary>
		/// 自动删除标识
		/// </summary>
		[Field("autodel")]
		
		public int? autodel
		{
			get { return _autodel; }
			set
			{
				this.OnPropertyValueChange("autodel");
				this._autodel = value;
			}
		}
		/// <summary>
		/// 是否删除标识 0-未删除 1-已删除
		/// </summary>
		[Field("isdel")]
		
		public int? isdel
		{
			get { return _isdel; }
			set
			{
				this.OnPropertyValueChange("isdel");
				this._isdel = value;
			}
		}
		/// <summary>
		/// 删除人
		/// </summary>
		[Field("deluser")]
		
		public string deluser
		{
			get { return _deluser; }
			set
			{
				this.OnPropertyValueChange("deluser");
				this._deluser = value;
			}
		}
		/// <summary>
		/// 除删时间
		/// </summary>
		[Field("deldate")]
		
		public int? deldate
		{
			get { return _deldate; }
			set
			{
				this.OnPropertyValueChange("deldate");
				this._deldate = value;
			}
		}
		/// <summary>
		/// 上传时间
		/// </summary>
		[Field("uploaddate")]
		
		public DateTime? uploaddate
		{
			get { return _uploaddate; }
			set
			{
				this.OnPropertyValueChange("uploaddate");
				this._uploaddate = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		[Field("creater")]
		
		public string creater
		{
			get { return _creater; }
			set
			{
				this.OnPropertyValueChange("creater");
				this._creater = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		[Field("moder")]
		
		public string moder
		{
			get { return _moder; }
			set
			{
				this.OnPropertyValueChange("moder");
				this._moder = value;
			}
		}
		/// <summary>
		/// 改修时间
		/// </summary>
		[Field("modtime")]
		
		public int? modtime
		{
			get { return _modtime; }
			set
			{
				this.OnPropertyValueChange("modtime");
				this._modtime = value;
			}
		}
		/// <summary>
		/// _0=不重要，1=重要
		/// </summary>
		[Field("major")]
		
		public string major
		{
			get { return _major; }
			set
			{
				this.OnPropertyValueChange("major");
				this._major = value;
			}
		}
		/// <summary>
		/// 视频的播放时间长度
		/// </summary>
		[Field("playtime")]
		
		public int? playtime
		{
			get { return _playtime; }
			set
			{
				this.OnPropertyValueChange("playtime");
				this._playtime = value;
			}
		}
		/// <summary>
		/// _0=普通，1=热点
		/// </summary>
		[Field("hot")]
		
		public int? hot
		{
			get { return _hot; }
			set
			{
				this.OnPropertyValueChange("hot");
				this._hot = value;
			}
		}
		/// <summary>
		/// 文件评论
		/// </summary>
		[Field("filecomment")]
		
		public string filecomment
		{
			get { return _filecomment; }
			set
			{
				this.OnPropertyValueChange("filecomment");
				this._filecomment = value;
			}
		}
		/// <summary>
		/// 视频像素分辨率
		/// </summary>
		[Field("resolution")]
		
		public string resolution
		{
			get { return _resolution; }
			set
			{
				this.OnPropertyValueChange("resolution");
				this._resolution = value;
			}
		}
		/// <summary>
		/// 此事件共有视频文件的个数
		/// </summary>
		[Field("filetotnum")]
		
		public int filetotnum
		{
			get { return _filetotnum; }
			set
			{
				this.OnPropertyValueChange("filetotnum");
				this._filetotnum = value;
			}
		}
		/// <summary>
		/// 此事件所有视频文件的总时长
		/// </summary>
		[Field("filetottime")]
		
		public int filetottime
		{
			get { return _filetottime; }
			set
			{
				this.OnPropertyValueChange("filetottime");
				this._filetottime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("vio_jdsbh")]
		
		public string vio_jdsbh
		{
			get { return _vio_jdsbh; }
			set
			{
				this.OnPropertyValueChange("vio_jdsbh");
				this._vio_jdsbh = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("conn_type")]
		
		public int? conn_type
		{
			get { return _conn_type; }
			set
			{
				this.OnPropertyValueChange("conn_type");
				this._conn_type = value;
			}
		}
		/// <summary>
		/// 存储天数
		/// </summary>
		[Field("save_date")]
		
		public int? save_date
		{
			get { return _save_date; }
			set
			{
				this.OnPropertyValueChange("save_date");
				this._save_date = value;
			}
		}
		/// <summary>
		/// 是否标注
		/// </summary>
		[Field("is_flg")]
		
		public int? is_flg
		{
			get { return _is_flg; }
			set
			{
				this.OnPropertyValueChange("is_flg");
				this._is_flg = value;
			}
		}
		/// <summary>
		/// 投诉内容
		/// </summary>
		[Field("tousu")]
		
		public string tousu
		{
			get { return _tousu; }
			set
			{
				this.OnPropertyValueChange("tousu");
				this._tousu = value;
			}
		}
		/// <summary>
		/// 检举内容
		/// </summary>
		[Field("jianju")]
		
		public string jianju
		{
			get { return _jianju; }
			set
			{
				this.OnPropertyValueChange("jianju");
				this._jianju = value;
			}
		}
		/// <summary>
		/// 上级指令内容
		/// </summary>
		[Field("sjzl")]
		
		public string sjzl
		{
			get { return _sjzl; }
			set
			{
				this.OnPropertyValueChange("sjzl");
				this._sjzl = value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.id,
				_.filename,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.id,
				_.filename,
				_.pfilename,
				_.bfilename,
				_.createdate,
				_.filelen,
				_.playfilelen,
				_.filetype,
				_.hostname,
				_.hostcode,
				_.hostbody,
				_.danwei,
				_.onlyread,
				_.safejb,
				_.caserank,
				_.casetopic,
				_.note,
				_.serverurl,
				_.servername,
				_.thumb,
				_.saveposition,
				_.playposition,
				_.macposition,
				_.media_play_url,
				_.source_type,
				_.querys,
				_.downloads,
				_.opens,
				_.sort,
				_.autodel,
				_.isdel,
				_.deluser,
				_.deldate,
				_.uploaddate,
				_.creater,
				_.moder,
				_.modtime,
				_.major,
				_.playtime,
				_.hot,
				_.filecomment,
				_.resolution,
				_.filetotnum,
				_.filetottime,
				_.vio_jdsbh,
				_.conn_type,
				_.save_date,
				_.is_flg,
				_.tousu,
				_.jianju,
				_.sjzl,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._id,
				this._filename,
				this._pfilename,
				this._bfilename,
				this._createdate,
				this._filelen,
				this._playfilelen,
				this._filetype,
				this._hostname,
				this._hostcode,
				this._hostbody,
				this._danwei,
				this._onlyread,
				this._safejb,
				this._caserank,
				this._casetopic,
				this._note,
				this._serverurl,
				this._servername,
				this._thumb,
				this._saveposition,
				this._playposition,
				this._macposition,
				this._media_play_url,
				this._source_type,
				this._querys,
				this._downloads,
				this._opens,
				this._sort,
				this._autodel,
				this._isdel,
				this._deluser,
				this._deldate,
				this._uploaddate,
				this._creater,
				this._moder,
				this._modtime,
				this._major,
				this._playtime,
				this._hot,
				this._filecomment,
				this._resolution,
				this._filetotnum,
				this._filetottime,
				this._vio_jdsbh,
				this._conn_type,
				this._save_date,
				this._is_flg,
				this._tousu,
				this._jianju,
				this._sjzl,
			};
		}
		/// <summary>
		/// 是否是v1.10.5.6及以上版本实体。
		/// </summary>
		/// <returns></returns>
		public override bool V1_10_5_6_Plus()
		{
			return true;
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "pe_video_list");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "pe_video_list", "");
			/// <summary>
			/// 文件名: 机身编号@生成日期
			/// </summary>
			public readonly static Field filename = new Field("filename", "pe_video_list", "文件名: 机身编号@生成日期");
			/// <summary>
			/// 前一文件名，衔接打包文件
			/// </summary>
			public readonly static Field pfilename = new Field("pfilename", "pe_video_list", "前一文件名，衔接打包文件");
			/// <summary>
			/// 文件别名
			/// </summary>
			public readonly static Field bfilename = new Field("bfilename", "pe_video_list", "文件别名");
			/// <summary>
			/// 建创日期
			/// </summary>
			public readonly static Field createdate = new Field("createdate", "pe_video_list", "建创日期");
			/// <summary>
			/// 文件长度
			/// </summary>
			public readonly static Field filelen = new Field("filelen", "pe_video_list", "文件长度");
			/// <summary>
			/// 文件播放长度
			/// </summary>
			public readonly static Field playfilelen = new Field("playfilelen", "pe_video_list", "文件播放长度");
			/// <summary>
			/// 文件类型
			/// </summary>
			public readonly static Field filetype = new Field("filetype", "pe_video_list", "文件类型");
			/// <summary>
			/// 机主名
			/// </summary>
			public readonly static Field hostname = new Field("hostname", "pe_video_list", "机主名");
			/// <summary>
			/// 机主编号
			/// </summary>
			public readonly static Field hostcode = new Field("hostcode", "pe_video_list", "机主编号");
			/// <summary>
			/// 机身编号
			/// </summary>
			public readonly static Field hostbody = new Field("hostbody", "pe_video_list", "机身编号");
			/// <summary>
			/// 单位编号
			/// </summary>
			public readonly static Field danwei = new Field("danwei", "pe_video_list", "单位编号");
			/// <summary>
			/// 只读属性 0-读写  1-只读
			/// </summary>
			public readonly static Field onlyread = new Field("onlyread", "pe_video_list", "只读属性 0-读写  1-只读");
			/// <summary>
			/// 安全级别 0- 1- 2- 3- 4-
			/// </summary>
			public readonly static Field safejb = new Field("safejb", "pe_video_list", "安全级别 0- 1- 2- 3- 4-");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field caserank = new Field("caserank", "pe_video_list", "");
			/// <summary>
			/// 案件专题编号
			/// </summary>
			public readonly static Field casetopic = new Field("casetopic", "pe_video_list", "案件专题编号");
			/// <summary>
			/// 注备
			/// </summary>
			public readonly static Field note = new Field("note", "pe_video_list", "注备");
			/// <summary>
			/// 服务器地址
			/// </summary>
			public readonly static Field serverurl = new Field("serverurl", "pe_video_list", "服务器地址");
			/// <summary>
			/// 服务器名称
			/// </summary>
			public readonly static Field servername = new Field("servername", "pe_video_list", "服务器名称");
			/// <summary>
			/// 缩略图
			/// </summary>
			public readonly static Field thumb = new Field("thumb", "pe_video_list", "缩略图");
			/// <summary>
			/// 存储位置
			/// </summary>
			public readonly static Field saveposition = new Field("saveposition", "pe_video_list", "存储位置");
			/// <summary>
			/// 播放位置
			/// </summary>
			public readonly static Field playposition = new Field("playposition", "pe_video_list", "播放位置");
			/// <summary>
			/// 存储的物理路径
			/// </summary>
			public readonly static Field macposition = new Field("macposition", "pe_video_list", "存储的物理路径");
			/// <summary>
			/// 播放位置
			/// </summary>
			public readonly static Field media_play_url = new Field("media_play_url", "pe_video_list", "播放位置");
			/// <summary>
			/// 判断播放位置
			/// </summary>
			public readonly static Field source_type = new Field("source_type", "pe_video_list", "判断播放位置");
			/// <summary>
			/// 查询次数
			/// </summary>
			public readonly static Field querys = new Field("querys", "pe_video_list", "查询次数");
			/// <summary>
			/// 下载次数
			/// </summary>
			public readonly static Field downloads = new Field("downloads", "pe_video_list", "下载次数");
			/// <summary>
			/// 播点次数
			/// </summary>
			public readonly static Field opens = new Field("opens", "pe_video_list", "播点次数");
			/// <summary>
			/// 分类
			/// </summary>
			public readonly static Field sort = new Field("sort", "pe_video_list", "分类");
			/// <summary>
			/// 自动删除标识
			/// </summary>
			public readonly static Field autodel = new Field("autodel", "pe_video_list", "自动删除标识");
			/// <summary>
			/// 是否删除标识 0-未删除 1-已删除
			/// </summary>
			public readonly static Field isdel = new Field("isdel", "pe_video_list", "是否删除标识 0-未删除 1-已删除");
			/// <summary>
			/// 删除人
			/// </summary>
			public readonly static Field deluser = new Field("deluser", "pe_video_list", "删除人");
			/// <summary>
			/// 除删时间
			/// </summary>
			public readonly static Field deldate = new Field("deldate", "pe_video_list", "除删时间");
			/// <summary>
			/// 上传时间
			/// </summary>
			public readonly static Field uploaddate = new Field("uploaddate", "pe_video_list", "上传时间");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field creater = new Field("creater", "pe_video_list", "创建人");
			/// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field moder = new Field("moder", "pe_video_list", "修改人");
			/// <summary>
			/// 改修时间
			/// </summary>
			public readonly static Field modtime = new Field("modtime", "pe_video_list", "改修时间");
			/// <summary>
			/// _0=不重要，1=重要
			/// </summary>
			public readonly static Field major = new Field("major", "pe_video_list", "_0=不重要，1=重要");
			/// <summary>
			/// 视频的播放时间长度
			/// </summary>
			public readonly static Field playtime = new Field("playtime", "pe_video_list", "视频的播放时间长度");
			/// <summary>
			/// _0=普通，1=热点
			/// </summary>
			public readonly static Field hot = new Field("hot", "pe_video_list", "_0=普通，1=热点");
			/// <summary>
			/// 文件评论
			/// </summary>
			public readonly static Field filecomment = new Field("filecomment", "pe_video_list", "文件评论");
			/// <summary>
			/// 视频像素分辨率
			/// </summary>
			public readonly static Field resolution = new Field("resolution", "pe_video_list", "视频像素分辨率");
			/// <summary>
			/// 此事件共有视频文件的个数
			/// </summary>
			public readonly static Field filetotnum = new Field("filetotnum", "pe_video_list", "此事件共有视频文件的个数");
			/// <summary>
			/// 此事件所有视频文件的总时长
			/// </summary>
			public readonly static Field filetottime = new Field("filetottime", "pe_video_list", "此事件所有视频文件的总时长");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field vio_jdsbh = new Field("vio_jdsbh", "pe_video_list", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field conn_type = new Field("conn_type", "pe_video_list", "");
			/// <summary>
			/// 存储天数
			/// </summary>
			public readonly static Field save_date = new Field("save_date", "pe_video_list", "存储天数");
			/// <summary>
			/// 是否标注
			/// </summary>
			public readonly static Field is_flg = new Field("is_flg", "pe_video_list", "是否标注");
			/// <summary>
			/// 投诉内容
			/// </summary>
			public readonly static Field tousu = new Field("tousu", "pe_video_list", "投诉内容");
			/// <summary>
			/// 检举内容
			/// </summary>
			public readonly static Field jianju = new Field("jianju", "pe_video_list", "检举内容");
			/// <summary>
			/// 上级指令内容
			/// </summary>
			public readonly static Field sjzl = new Field("sjzl", "pe_video_list", "上级指令内容");
		}
		#endregion
	}
}
