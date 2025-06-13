using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C7 RID: 1479
	[System.Serializable]
	public class NewMixOperation : Il2CppSystem.Object
	{
		// Token: 0x06008059 RID: 32857 RVA: 0x00227804 File Offset: 0x00225A04
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixOperation()
		{
			Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr);
			NewMixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "ProductID");
			NewMixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "IngredientID");
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679448);
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679449);
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00227884 File Offset: 0x00225A84
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 114146, RefRangeEnd = 114197, XrefRangeStart = 114146, XrefRangeEnd = 114197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation(string productID, string ingredientID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x002278E4 File Offset: 0x00225AE4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x0003CBCB File Offset: 0x0003ADCB
		public NewMixOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600805D RID: 32861 RVA: 0x00227920 File Offset: 0x00225B20
		// (set) Token: 0x0600805E RID: 32862 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		public unsafe string ProductID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600805F RID: 32863 RVA: 0x00227948 File Offset: 0x00225B48
		// (set) Token: 0x06008060 RID: 32864 RVA: 0x0003CBF3 File Offset: 0x0003ADF3
		public unsafe string IngredientID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400575F RID: 22367
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x04005760 RID: 22368
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x04005761 RID: 22369
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04005762 RID: 22370
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
