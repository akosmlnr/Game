using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0010E700 File Offset: 0x0010C900
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemData()
		{
			Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "IntegerItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr);
			IntegerItemData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, "Value");
			IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, 100669003);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0010E758 File Offset: 0x0010C958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136636, RefRangeEnd = 136638, XrefRangeStart = 136636, XrefRangeEnd = 136638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemData(string iD, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0001955E File Offset: 0x0001775E
		public IntegerItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0010E7C0 File Offset: 0x0010C9C0
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00019567 File Offset: 0x00017767
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
