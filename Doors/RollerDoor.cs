using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000449 RID: 1097
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x06005F74 RID: 24436 RVA: 0x001B9FB4 File Offset: 0x001B81B4
		// Note: this type is marked as 'beforefieldinit'.
		static RollerDoor()
		{
			Il2CppClassPointerStore<RollerDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "RollerDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr);
			RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			RollerDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Door");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Open");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Closed");
			RollerDoor.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LerpTime");
			RollerDoor.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Blocker");
			RollerDoor.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "startPos");
			RollerDoor.NativeFieldInfoPtr_timeSinceValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "timeSinceValueChange");
			RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675539);
			RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675540);
			RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675541);
			RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675542);
			RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675543);
			RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675544);
			RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675545);
			RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675546);
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06005F75 RID: 24437 RVA: 0x001BA124 File Offset: 0x001B8324
		// (set) Token: 0x06005F76 RID: 24438 RVA: 0x001BA160 File Offset: 0x001B8360
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x001BA1A0 File Offset: 0x001B83A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200437, XrefRangeEnd = 200439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x001BA1D4 File Offset: 0x001B83D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200439, XrefRangeEnd = 200451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x001BA208 File Offset: 0x001B8408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200451, XrefRangeEnd = 200452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x001BA23C File Offset: 0x001B843C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200453, RefRangeEnd = 200454, XrefRangeStart = 200452, XrefRangeEnd = 200453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x001BA270 File Offset: 0x001B8470
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x001BA2B8 File Offset: 0x001B84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200454, XrefRangeEnd = 200457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollerDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0002CC76 File Offset: 0x0002AE76
		public RollerDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x001BA2F4 File Offset: 0x001B84F4
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x0002CC7F File Offset: 0x0002AE7F
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x001BA31C File Offset: 0x001B851C
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x0002CC9A File Offset: 0x0002AE9A
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x001BA34C File Offset: 0x001B854C
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x0002CCB9 File Offset: 0x0002AEB9
		public unsafe Vector3 LocalPos_Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open)) = value;
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x001BA374 File Offset: 0x001B8574
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0002CCD4 File Offset: 0x0002AED4
		public unsafe Vector3 LocalPos_Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed)) = value;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x001BA39C File Offset: 0x001B859C
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x0002CCEF File Offset: 0x0002AEEF
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x001BA3C4 File Offset: 0x001B85C4
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x0002CD0A File Offset: 0x0002AF0A
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x001BA3F4 File Offset: 0x001B85F4
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x0002CD29 File Offset: 0x0002AF29
		public unsafe Vector3 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x001BA41C File Offset: 0x001B861C
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x0002CD44 File Offset: 0x0002AF44
		public unsafe float timeSinceValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange)) = value;
			}
		}

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Open;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Closed;

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceValueChange;

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
