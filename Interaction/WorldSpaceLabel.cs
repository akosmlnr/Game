using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000415 RID: 1045
	public class WorldSpaceLabel : Il2CppSystem.Object
	{
		// Token: 0x060055AD RID: 21933 RVA: 0x00193F28 File Offset: 0x00192128
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceLabel()
		{
			Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "WorldSpaceLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr);
			WorldSpaceLabel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "text");
			WorldSpaceLabel.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "color");
			WorldSpaceLabel.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "position");
			WorldSpaceLabel.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "scale");
			WorldSpaceLabel.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "rect");
			WorldSpaceLabel.NativeFieldInfoPtr_textComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "textComp");
			WorldSpaceLabel.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "active");
			WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100674065);
			WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100674066);
			WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100674067);
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00194020 File Offset: 0x00192220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184069, RefRangeEnd = 184070, XrefRangeStart = 184011, XrefRangeEnd = 184069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceLabel(string _text, Vector3 _position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x0019407C File Offset: 0x0019227C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184099, RefRangeEnd = 184101, XrefRangeStart = 184070, XrefRangeEnd = 184099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x001940B0 File Offset: 0x001922B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184116, RefRangeEnd = 184117, XrefRangeStart = 184101, XrefRangeEnd = 184116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00028C6E File Offset: 0x00026E6E
		public WorldSpaceLabel(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x001940E4 File Offset: 0x001922E4
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x00028C77 File Offset: 0x00026E77
		public unsafe string text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0019410C File Offset: 0x0019230C
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x00028C96 File Offset: 0x00026E96
		public unsafe Color32 color
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x00194134 File Offset: 0x00192334
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x00028CB1 File Offset: 0x00026EB1
		public unsafe Vector3 position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x0019415C File Offset: 0x0019235C
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x00028CCC File Offset: 0x00026ECC
		public unsafe float scale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x060055BA RID: 21946 RVA: 0x00194184 File Offset: 0x00192384
		// (set) Token: 0x060055BB RID: 21947 RVA: 0x00028CE7 File Offset: 0x00026EE7
		public unsafe RectTransform rect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x001941B4 File Offset: 0x001923B4
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x00028D06 File Offset: 0x00026F06
		public unsafe Text textComp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x001941E4 File Offset: 0x001923E4
		// (set) Token: 0x060055BF RID: 21951 RVA: 0x00028D25 File Offset: 0x00026F25
		public unsafe bool active
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x04003A0B RID: 14859
		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04003A0C RID: 14860
		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04003A0D RID: 14861
		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04003A0E RID: 14862
		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04003A0F RID: 14863
		private static readonly System.IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04003A10 RID: 14864
		private static readonly System.IntPtr NativeFieldInfoPtr_textComp;

		// Token: 0x04003A11 RID: 14865
		private static readonly System.IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04003A12 RID: 14866
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0;

		// Token: 0x04003A13 RID: 14867
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDisplay_Public_Void_0;

		// Token: 0x04003A14 RID: 14868
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
	}
}
