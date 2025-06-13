using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027D RID: 637
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x0010E598 File Offset: 0x0010C798
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingData()
		{
			Il2CppClassPointerStore<ClothingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ClothingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingData>.NativeClassPtr);
			ClothingData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, "Color");
			ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, 100669001);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x0010E5F0 File Offset: 0x0010C7F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136636, RefRangeEnd = 136638, XrefRangeStart = 136634, XrefRangeEnd = 136636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingData(string iD, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000194F8 File Offset: 0x000176F8
		public ClothingData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x0010E658 File Offset: 0x0010C858
		// (set) Token: 0x06003062 RID: 12386 RVA: 0x00019501 File Offset: 0x00017701
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0;
	}
}
