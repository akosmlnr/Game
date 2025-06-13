using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000297 RID: 663
	[System.Serializable]
	public class NumberFieldData : Il2CppSystem.Object
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x0010FEB8 File Offset: 0x0010E0B8
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldData()
		{
			Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NumberFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr);
			NumberFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, "Value");
			NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, 100669028);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0010FF10 File Offset: 0x0010E110
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 136672, RefRangeEnd = 136815, XrefRangeStart = 136671, XrefRangeEnd = 136672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData(float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x00019AF6 File Offset: 0x00017CF6
		public NumberFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x0010FF58 File Offset: 0x0010E158
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x00019AFF File Offset: 0x00017CFF
		public unsafe float Value
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04002038 RID: 8248
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04002039 RID: 8249
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
