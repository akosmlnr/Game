using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000555 RID: 1365
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x0600789E RID: 30878 RVA: 0x0020E530 File Offset: 0x0020C730
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownText()
		{
			Il2CppClassPointerStore<CountdownText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CountdownText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownText>.NativeClassPtr);
			CountdownText.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "TimeLabel");
			CountdownText.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Year");
			CountdownText.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Month");
			CountdownText.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Day");
			CountdownText.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Hour");
			CountdownText.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Minute");
			CountdownText.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Second");
			CountdownText.NativeFieldInfoPtr_targetPDTDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "targetPDTDate");
			CountdownText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678583);
			CountdownText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678584);
			CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678585);
			CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678586);
			CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678587);
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x0020E664 File Offset: 0x0020C864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234714, XrefRangeEnd = 234725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x0020E698 File Offset: 0x0020C898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234725, XrefRangeEnd = 234736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x0020E6CC File Offset: 0x0020C8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x0020E700 File Offset: 0x0020C900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234736, XrefRangeEnd = 234761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTime(Il2CppSystem.TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref timeSpan;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x0020E744 File Offset: 0x0020C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234761, XrefRangeEnd = 234762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownText>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x00038E85 File Offset: 0x00037085
		public CountdownText(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x060078A5 RID: 30885 RVA: 0x0020E780 File Offset: 0x0020C980
		// (set) Token: 0x060078A6 RID: 30886 RVA: 0x00038E8E File Offset: 0x0003708E
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x0020E7B0 File Offset: 0x0020C9B0
		// (set) Token: 0x060078A8 RID: 30888 RVA: 0x00038EAD File Offset: 0x000370AD
		public unsafe int Year
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x060078A9 RID: 30889 RVA: 0x0020E7D8 File Offset: 0x0020C9D8
		// (set) Token: 0x060078AA RID: 30890 RVA: 0x00038EC8 File Offset: 0x000370C8
		public unsafe int Month
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x0020E800 File Offset: 0x0020CA00
		// (set) Token: 0x060078AC RID: 30892 RVA: 0x00038EE3 File Offset: 0x000370E3
		public unsafe int Day
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x0020E828 File Offset: 0x0020CA28
		// (set) Token: 0x060078AE RID: 30894 RVA: 0x00038EFE File Offset: 0x000370FE
		public unsafe int Hour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x0020E850 File Offset: 0x0020CA50
		// (set) Token: 0x060078B0 RID: 30896 RVA: 0x00038F19 File Offset: 0x00037119
		public unsafe int Minute
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x0020E878 File Offset: 0x0020CA78
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x00038F34 File Offset: 0x00037134
		public unsafe int Second
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x0020E8A0 File Offset: 0x0020CAA0
		// (set) Token: 0x060078B4 RID: 30900 RVA: 0x00038F4F File Offset: 0x0003714F
		public unsafe Il2CppSystem.DateTime targetPDTDate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate)) = value;
			}
		}

		// Token: 0x04005265 RID: 21093
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04005266 RID: 21094
		private static readonly System.IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04005267 RID: 21095
		private static readonly System.IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04005268 RID: 21096
		private static readonly System.IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04005269 RID: 21097
		private static readonly System.IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x0400526A RID: 21098
		private static readonly System.IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x0400526B RID: 21099
		private static readonly System.IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x0400526C RID: 21100
		private static readonly System.IntPtr NativeFieldInfoPtr_targetPDTDate;

		// Token: 0x0400526D RID: 21101
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400526E RID: 21102
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400526F RID: 21103
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCountdown_Private_Void_0;

		// Token: 0x04005270 RID: 21104
		private static readonly System.IntPtr NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0;

		// Token: 0x04005271 RID: 21105
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
