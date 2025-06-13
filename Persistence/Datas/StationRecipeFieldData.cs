using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029F RID: 671
	[System.Serializable]
	public class StationRecipeFieldData : Il2CppSystem.Object
	{
		// Token: 0x06003129 RID: 12585 RVA: 0x00110740 File Offset: 0x0010E940
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldData()
		{
			Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StationRecipeFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr);
			StationRecipeFieldData.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, "RecipeID");
			StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, 100669036);
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00110798 File Offset: 0x0010E998
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData(string recipeID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00019CE8 File Offset: 0x00017EE8
		public StationRecipeFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x001107E4 File Offset: 0x0010E9E4
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x00019CF1 File Offset: 0x00017EF1
		public unsafe string RecipeID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400204E RID: 8270
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x0400204F RID: 8271
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
