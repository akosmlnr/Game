using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000287 RID: 647
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0010EDF8 File Offset: 0x0010CFF8
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanData()
		{
			Il2CppClassPointerStore<WateringCanData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WateringCanData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr);
			WateringCanData.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, "CurrentFillAmount");
			WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, 100669011);
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0010EE50 File Offset: 0x0010D050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136632, RefRangeEnd = 136634, XrefRangeStart = 136632, XrefRangeEnd = 136634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanData(string iD, int quantity, float currentFillLevel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFillLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0001971B File Offset: 0x0001791B
		public WateringCanData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0010EEB8 File Offset: 0x0010D0B8
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x00019724 File Offset: 0x00017924
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
