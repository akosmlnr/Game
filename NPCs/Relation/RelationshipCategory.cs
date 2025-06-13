using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x02000311 RID: 785
	public class RelationshipCategory : Il2CppSystem.Object
	{
		// Token: 0x06003A4F RID: 14927 RVA: 0x00131A78 File Offset: 0x0012FC78
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipCategory()
		{
			Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "RelationshipCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr);
			RelationshipCategory.NativeFieldInfoPtr_Hostile_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Hostile_Color");
			RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Unfriendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Neutral_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Neutral_Color");
			RelationshipCategory.NativeFieldInfoPtr_Friendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Friendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Loyal_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Loyal_Color");
			RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100670165);
			RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100670166);
			RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100670167);
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00131B48 File Offset: 0x0012FD48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147193, RefRangeEnd = 147196, XrefRangeStart = 147193, XrefRangeEnd = 147193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERelationshipCategory GetCategory(float delta)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref delta;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00131B88 File Offset: 0x0012FD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147204, RefRangeEnd = 147206, XrefRangeStart = 147196, XrefRangeEnd = 147204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(ERelationshipCategory category)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00131BC8 File Offset: 0x0012FDC8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x0001DC95 File Offset: 0x0001BE95
		public RelationshipCategory(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00131C04 File Offset: 0x0012FE04
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x0001DC9E File Offset: 0x0001BE9E
		public unsafe static Color32 Hostile_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&value));
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00131C20 File Offset: 0x0012FE20
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		public unsafe static Color32 Unfriendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&value));
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x00131C3C File Offset: 0x0012FE3C
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x0001DCBA File Offset: 0x0001BEBA
		public unsafe static Color32 Neutral_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&value));
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x00131C58 File Offset: 0x0012FE58
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		public unsafe static Color32 Friendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&value));
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x00131C74 File Offset: 0x0012FE74
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x0001DCD6 File Offset: 0x0001BED6
		public unsafe static Color32 Loyal_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&value));
			}
		}

		// Token: 0x0400267B RID: 9851
		private static readonly System.IntPtr NativeFieldInfoPtr_Hostile_Color;

		// Token: 0x0400267C RID: 9852
		private static readonly System.IntPtr NativeFieldInfoPtr_Unfriendly_Color;

		// Token: 0x0400267D RID: 9853
		private static readonly System.IntPtr NativeFieldInfoPtr_Neutral_Color;

		// Token: 0x0400267E RID: 9854
		private static readonly System.IntPtr NativeFieldInfoPtr_Friendly_Color;

		// Token: 0x0400267F RID: 9855
		private static readonly System.IntPtr NativeFieldInfoPtr_Loyal_Color;

		// Token: 0x04002680 RID: 9856
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0;

		// Token: 0x04002681 RID: 9857
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0;

		// Token: 0x04002682 RID: 9858
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
