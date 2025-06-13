using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000650 RID: 1616
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x06008D8A RID: 36234 RVA: 0x00252A44 File Offset: 0x00250C44
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterInterface()
		{
			Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr);
			CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterInterface.NativeFieldInfoPtr_ClothingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "ClothingSlots");
			CharacterInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "Container");
			CharacterInterface.NativeFieldInfoPtr_RotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "RotationSlider");
			CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "SlotAlignmentPoints");
			CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680974);
			CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680975);
			CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680976);
			CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680977);
			CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680978);
			CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680979);
			CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680980);
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x06008D8B RID: 36235 RVA: 0x00252B64 File Offset: 0x00250D64
		// (set) Token: 0x06008D8C RID: 36236 RVA: 0x00252BA0 File Offset: 0x00250DA0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x00252BE0 File Offset: 0x00250DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258998, RefRangeEnd = 258999, XrefRangeStart = 258995, XrefRangeEnd = 258998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x00252C14 File Offset: 0x00250E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259016, RefRangeEnd = 259017, XrefRangeStart = 258999, XrefRangeEnd = 259016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00252C48 File Offset: 0x00250E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259066, RefRangeEnd = 259067, XrefRangeStart = 259017, XrefRangeEnd = 259066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x00252C7C File Offset: 0x00250E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258998, RefRangeEnd = 258999, XrefRangeStart = 258998, XrefRangeEnd = 258999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00252CB0 File Offset: 0x00250EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259067, XrefRangeEnd = 259075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x000437FA File Offset: 0x000419FA
		public CharacterInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x06008D93 RID: 36243 RVA: 0x00252CEC File Offset: 0x00250EEC
		// (set) Token: 0x06008D94 RID: 36244 RVA: 0x00043803 File Offset: 0x00041A03
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06008D95 RID: 36245 RVA: 0x00252D14 File Offset: 0x00250F14
		// (set) Token: 0x06008D96 RID: 36246 RVA: 0x0004381E File Offset: 0x00041A1E
		public unsafe Il2CppReferenceArray<ClothingSlotUI> ClothingSlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothingSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06008D97 RID: 36247 RVA: 0x00252D44 File Offset: 0x00250F44
		// (set) Token: 0x06008D98 RID: 36248 RVA: 0x0004383D File Offset: 0x00041A3D
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06008D99 RID: 36249 RVA: 0x00252D74 File Offset: 0x00250F74
		// (set) Token: 0x06008D9A RID: 36250 RVA: 0x0004385C File Offset: 0x00041A5C
		public unsafe Slider RotationSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x00252DA4 File Offset: 0x00250FA4
		// (set) Token: 0x06008D9C RID: 36252 RVA: 0x0004387B File Offset: 0x00041A7B
		public unsafe Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClothingSlotUI, Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006000 RID: 24576
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006001 RID: 24577
		private static readonly System.IntPtr NativeFieldInfoPtr_ClothingSlots;

		// Token: 0x04006002 RID: 24578
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006003 RID: 24579
		private static readonly System.IntPtr NativeFieldInfoPtr_RotationSlider;

		// Token: 0x04006004 RID: 24580
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotAlignmentPoints;

		// Token: 0x04006005 RID: 24581
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006006 RID: 24582
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006007 RID: 24583
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006008 RID: 24584
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006009 RID: 24585
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400600A RID: 24586
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400600B RID: 24587
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("ScheduleOne.UI.CharacterInterface+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBFC RID: 56316 RVA: 0x00347B38 File Offset: 0x00345D38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr);
				CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, "slotUI");
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680981);
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680982);
			}

			// Token: 0x0600DBFD RID: 56317 RVA: 0x00347BA0 File Offset: 0x00345DA0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBFE RID: 56318 RVA: 0x00347BDC File Offset: 0x00345DDC
			[CallerCount(0)]
			public unsafe bool _Open_b__0(CharacterDisplay.SlotAlignmentPoint x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DBFF RID: 56319 RVA: 0x0006ABD5 File Offset: 0x00068DD5
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0600DC00 RID: 56320 RVA: 0x00347C2C File Offset: 0x00345E2C
			// (set) Token: 0x0600DC01 RID: 56321 RVA: 0x0006ABDE File Offset: 0x00068DDE
			public unsafe ClothingSlotUI slotUI
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingSlotUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009402 RID: 37890
			private static readonly System.IntPtr NativeFieldInfoPtr_slotUI;

			// Token: 0x04009403 RID: 37891
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009404 RID: 37892
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0;
		}
	}
}
