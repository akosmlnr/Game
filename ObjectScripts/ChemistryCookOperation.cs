using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200076C RID: 1900
	public class ChemistryCookOperation : Il2CppSystem.Object
	{
		// Token: 0x0600AF1F RID: 44831 RVA: 0x002BD0A0 File Offset: 0x002BB2A0
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryCookOperation()
		{
			Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "ChemistryCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr);
			ChemistryCookOperation.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "recipe");
			ChemistryCookOperation.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "RecipeID");
			ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "ProductQuality");
			ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "StartLiquidColor");
			ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "LiquidLevel");
			ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "CurrentTime");
			ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684897);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684898);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684899);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684900);
			ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684901);
			ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684902);
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x002BD1C0 File Offset: 0x002BB3C0
		public unsafe StationRecipe Recipe
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 302991, RefRangeEnd = 303002, XrefRangeStart = 302973, XrefRangeEnd = 302991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x002BD200 File Offset: 0x002BB400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303005, RefRangeEnd = 303007, XrefRangeStart = 303002, XrefRangeEnd = 303005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x002BD284 File Offset: 0x002BB484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303009, RefRangeEnd = 303011, XrefRangeStart = 303007, XrefRangeEnd = 303009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x002BD308 File Offset: 0x002BB508
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002BD344 File Offset: 0x002BB544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303011, XrefRangeEnd = 303012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Progress(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mins;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x002BD384 File Offset: 0x002BB584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303012, XrefRangeEnd = 303015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Recipe_b__2_0(StationRecipe r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x00055F0B File Offset: 0x0005410B
		public ChemistryCookOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600AF27 RID: 44839 RVA: 0x002BD3D4 File Offset: 0x002BB5D4
		// (set) Token: 0x0600AF28 RID: 44840 RVA: 0x00055F14 File Offset: 0x00054114
		public unsafe StationRecipe recipe
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600AF29 RID: 44841 RVA: 0x002BD404 File Offset: 0x002BB604
		// (set) Token: 0x0600AF2A RID: 44842 RVA: 0x00055F33 File Offset: 0x00054133
		public unsafe string RecipeID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600AF2B RID: 44843 RVA: 0x002BD42C File Offset: 0x002BB62C
		// (set) Token: 0x0600AF2C RID: 44844 RVA: 0x00055F52 File Offset: 0x00054152
		public unsafe EQuality ProductQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600AF2D RID: 44845 RVA: 0x002BD454 File Offset: 0x002BB654
		// (set) Token: 0x0600AF2E RID: 44846 RVA: 0x00055F6D File Offset: 0x0005416D
		public unsafe Color StartLiquidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600AF2F RID: 44847 RVA: 0x002BD47C File Offset: 0x002BB67C
		// (set) Token: 0x0600AF30 RID: 44848 RVA: 0x00055F88 File Offset: 0x00054188
		public unsafe float LiquidLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600AF31 RID: 44849 RVA: 0x002BD4A4 File Offset: 0x002BB6A4
		// (set) Token: 0x0600AF32 RID: 44850 RVA: 0x00055FA3 File Offset: 0x000541A3
		public unsafe int CurrentTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x040075B7 RID: 30135
		private static readonly System.IntPtr NativeFieldInfoPtr_recipe;

		// Token: 0x040075B8 RID: 30136
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x040075B9 RID: 30137
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x040075BA RID: 30138
		private static readonly System.IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x040075BB RID: 30139
		private static readonly System.IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x040075BC RID: 30140
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x040075BD RID: 30141
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x040075BE RID: 30142
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0;

		// Token: 0x040075BF RID: 30143
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0;

		// Token: 0x040075C0 RID: 30144
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040075C1 RID: 30145
		private static readonly System.IntPtr NativeMethodInfoPtr_Progress_Public_Void_Int32_0;

		// Token: 0x040075C2 RID: 30146
		private static readonly System.IntPtr NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0;
	}
}
