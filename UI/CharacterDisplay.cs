using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064F RID: 1615
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x06008D72 RID: 36210 RVA: 0x002525C8 File Offset: 0x002507C8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterDisplay()
		{
			Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr);
			CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AlignmentPoints");
			CharacterDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Container");
			CharacterDisplay.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "ParentAvatar");
			CharacterDisplay.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Avatar");
			CharacterDisplay.NativeFieldInfoPtr_AvatarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AvatarContainer");
			CharacterDisplay.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "targetRotation");
			CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680965);
			CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680966);
			CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680967);
			CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680968);
			CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680969);
			CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680970);
			CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680971);
			CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680972);
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x06008D73 RID: 36211 RVA: 0x00252724 File Offset: 0x00250924
		// (set) Token: 0x06008D74 RID: 36212 RVA: 0x00252760 File Offset: 0x00250960
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x002527A0 File Offset: 0x002509A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258903, XrefRangeEnd = 258924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x002527DC File Offset: 0x002509DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258946, RefRangeEnd = 258951, XrefRangeStart = 258924, XrefRangeEnd = 258946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x0025281C File Offset: 0x00250A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258951, XrefRangeEnd = 258959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x00252850 File Offset: 0x00250A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258987, RefRangeEnd = 258990, XrefRangeStart = 258959, XrefRangeEnd = 258987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x00252894 File Offset: 0x00250A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258990, XrefRangeEnd = 258993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x002528D0 File Offset: 0x00250AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258993, XrefRangeEnd = 258995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x00043720 File Offset: 0x00041920
		public CharacterDisplay(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x00252904 File Offset: 0x00250B04
		// (set) Token: 0x06008D7D RID: 36221 RVA: 0x00043729 File Offset: 0x00041929
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x0025292C File Offset: 0x00250B2C
		// (set) Token: 0x06008D7F RID: 36223 RVA: 0x00043744 File Offset: 0x00041944
		public unsafe Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint> AlignmentPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x06008D80 RID: 36224 RVA: 0x0025295C File Offset: 0x00250B5C
		// (set) Token: 0x06008D81 RID: 36225 RVA: 0x00043763 File Offset: 0x00041963
		public unsafe Transform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x06008D82 RID: 36226 RVA: 0x0025298C File Offset: 0x00250B8C
		// (set) Token: 0x06008D83 RID: 36227 RVA: 0x00043782 File Offset: 0x00041982
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x002529BC File Offset: 0x00250BBC
		// (set) Token: 0x06008D85 RID: 36229 RVA: 0x000437A1 File Offset: 0x000419A1
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x06008D86 RID: 36230 RVA: 0x002529EC File Offset: 0x00250BEC
		// (set) Token: 0x06008D87 RID: 36231 RVA: 0x000437C0 File Offset: 0x000419C0
		public unsafe Transform AvatarContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x00252A1C File Offset: 0x00250C1C
		// (set) Token: 0x06008D89 RID: 36233 RVA: 0x000437DF File Offset: 0x000419DF
		public unsafe float targetRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x04005FF1 RID: 24561
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FF2 RID: 24562
		private static readonly System.IntPtr NativeFieldInfoPtr_AlignmentPoints;

		// Token: 0x04005FF3 RID: 24563
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005FF4 RID: 24564
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x04005FF5 RID: 24565
		private static readonly System.IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005FF6 RID: 24566
		private static readonly System.IntPtr NativeFieldInfoPtr_AvatarContainer;

		// Token: 0x04005FF7 RID: 24567
		private static readonly System.IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04005FF8 RID: 24568
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FF9 RID: 24569
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005FFA RID: 24570
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005FFB RID: 24571
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04005FFC RID: 24572
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005FFD RID: 24573
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x04005FFE RID: 24574
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005FFF RID: 24575
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0;

		// Token: 0x02000B64 RID: 2916
		[System.Serializable]
		public class SlotAlignmentPoint : Il2CppSystem.Object
		{
			// Token: 0x0600DBF5 RID: 56309 RVA: 0x00347A3C File Offset: 0x00345C3C
			// Note: this type is marked as 'beforefieldinit'.
			static SlotAlignmentPoint()
			{
				Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "SlotAlignmentPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr);
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "SlotType");
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "Point");
				CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, 100680973);
			}

			// Token: 0x0600DBF6 RID: 56310 RVA: 0x00347AA4 File Offset: 0x00345CA4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SlotAlignmentPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBF7 RID: 56311 RVA: 0x0006AB92 File Offset: 0x00068D92
			public SlotAlignmentPoint(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D5 RID: 17365
			// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x00347AE0 File Offset: 0x00345CE0
			// (set) Token: 0x0600DBF9 RID: 56313 RVA: 0x0006AB9B File Offset: 0x00068D9B
			public unsafe EClothingSlot SlotType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType)) = value;
				}
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x00347B08 File Offset: 0x00345D08
			// (set) Token: 0x0600DBFB RID: 56315 RVA: 0x0006ABB6 File Offset: 0x00068DB6
			public unsafe Transform Point
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093FF RID: 37887
			private static readonly System.IntPtr NativeFieldInfoPtr_SlotType;

			// Token: 0x04009400 RID: 37888
			private static readonly System.IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x04009401 RID: 37889
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
