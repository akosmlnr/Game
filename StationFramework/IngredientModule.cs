using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AB RID: 1451
	public class IngredientModule : ItemModule
	{
		// Token: 0x06007ED2 RID: 32466 RVA: 0x00222C84 File Offset: 0x00220E84
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientModule()
		{
			Il2CppClassPointerStore<IngredientModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr);
			IngredientModule.NativeFieldInfoPtr_Pieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, "Pieces");
			IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100679285);
			IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100679286);
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00222CF0 File Offset: 0x00220EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241328, XrefRangeEnd = 241336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00222D40 File Offset: 0x00220F40
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x0003BF1E File Offset: 0x0003A11E
		public IngredientModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x00222D7C File Offset: 0x00220F7C
		// (set) Token: 0x06007ED7 RID: 32471 RVA: 0x0003BF27 File Offset: 0x0003A127
		public unsafe Il2CppReferenceArray<IngredientPiece> Pieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400565B RID: 22107
		private static readonly IntPtr NativeFieldInfoPtr_Pieces;

		// Token: 0x0400565C RID: 22108
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x0400565D RID: 22109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
