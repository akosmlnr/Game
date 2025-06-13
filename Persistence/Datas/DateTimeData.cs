using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000274 RID: 628
	[System.Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06002FFE RID: 12286 RVA: 0x0010D1F8 File Offset: 0x0010B3F8
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeData()
		{
			Il2CppClassPointerStore<DateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr);
			DateTimeData.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Year");
			DateTimeData.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Month");
			DateTimeData.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Day");
			DateTimeData.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Hour");
			DateTimeData.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Minute");
			DateTimeData.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Second");
			DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668960);
			DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668961);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0010D2C8 File Offset: 0x0010B4C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136237, RefRangeEnd = 136243, XrefRangeStart = 136227, XrefRangeEnd = 136237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeData(Il2CppSystem.DateTime date) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref date;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0010D310 File Offset: 0x0010B510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136244, RefRangeEnd = 136247, XrefRangeStart = 136243, XrefRangeEnd = 136244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.DateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000191D0 File Offset: 0x000173D0
		public DateTimeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x0010D34C File Offset: 0x0010B54C
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x000191D9 File Offset: 0x000173D9
		public unsafe int Year
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x0010D374 File Offset: 0x0010B574
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x000191F4 File Offset: 0x000173F4
		public unsafe int Month
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x0010D39C File Offset: 0x0010B59C
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x0001920F File Offset: 0x0001740F
		public unsafe int Day
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x0010D3C4 File Offset: 0x0010B5C4
		// (set) Token: 0x06003009 RID: 12297 RVA: 0x0001922A File Offset: 0x0001742A
		public unsafe int Hour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0010D3EC File Offset: 0x0010B5EC
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x00019245 File Offset: 0x00017445
		public unsafe int Minute
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x0010D414 File Offset: 0x0010B614
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x00019260 File Offset: 0x00017460
		public unsafe int Second
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x04001FC4 RID: 8132
		private static readonly System.IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04001FC5 RID: 8133
		private static readonly System.IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04001FC6 RID: 8134
		private static readonly System.IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04001FC7 RID: 8135
		private static readonly System.IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04001FC8 RID: 8136
		private static readonly System.IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04001FC9 RID: 8137
		private static readonly System.IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04001FCA RID: 8138
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTime_Public_DateTime_0;
	}
}
