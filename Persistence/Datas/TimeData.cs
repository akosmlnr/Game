using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D6 RID: 726
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x06003332 RID: 13106 RVA: 0x001165C8 File Offset: 0x001147C8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeData()
		{
			Il2CppClassPointerStore<TimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeData>.NativeClassPtr);
			TimeData.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "TimeOfDay");
			TimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "ElapsedDays");
			TimeData.NativeFieldInfoPtr_Playtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "Playtime");
			TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeData>.NativeClassPtr, 100669099);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00116648 File Offset: 0x00114848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137242, RefRangeEnd = 137243, XrefRangeStart = 137241, XrefRangeEnd = 137242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeData(int timeOfDay, int elapsedDays, int playtime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playtime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x0001B2BF File Offset: 0x000194BF
		public TimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x001166AC File Offset: 0x001148AC
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x0001B2C8 File Offset: 0x000194C8
		public unsafe int TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x001166D4 File Offset: 0x001148D4
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x0001B2E3 File Offset: 0x000194E3
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x001166FC File Offset: 0x001148FC
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x0001B2FE File Offset: 0x000194FE
		public unsafe int Playtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime)) = value;
			}
		}

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDay;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeFieldInfoPtr_Playtime;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
	}
}
