using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000632 RID: 1586
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x06008B74 RID: 35700 RVA: 0x0024C6F0 File Offset: 0x0024A8F0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeat()
		{
			Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr);
			AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "<Occupant>k__BackingField");
			AvatarSeat.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "SittingPoint");
			AvatarSeat.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "AccessPoint");
			AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680751);
			AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680752);
			AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680753);
			AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680754);
			AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680755);
			AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680756);
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06008B75 RID: 35701 RVA: 0x0024C7D4 File Offset: 0x0024A9D4
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257179, XrefRangeEnd = 257183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06008B76 RID: 35702 RVA: 0x0024C810 File Offset: 0x0024AA10
		// (set) Token: 0x06008B77 RID: 35703 RVA: 0x0024C850 File Offset: 0x0024AA50
		public unsafe NPC Occupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x0024C894 File Offset: 0x0024AA94
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x0024C8C8 File Offset: 0x0024AAC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257198, RefRangeEnd = 257201, XrefRangeStart = 257183, XrefRangeEnd = 257198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x0024C90C File Offset: 0x0024AB0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00042561 File Offset: 0x00040761
		public AvatarSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06008B7C RID: 35708 RVA: 0x0024C948 File Offset: 0x0024AB48
		// (set) Token: 0x06008B7D RID: 35709 RVA: 0x0004256A File Offset: 0x0004076A
		public unsafe NPC _Occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x0024C978 File Offset: 0x0024AB78
		// (set) Token: 0x06008B7F RID: 35711 RVA: 0x00042589 File Offset: 0x00040789
		public unsafe Transform SittingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06008B80 RID: 35712 RVA: 0x0024C9A8 File Offset: 0x0024ABA8
		// (set) Token: 0x06008B81 RID: 35713 RVA: 0x000425A8 File Offset: 0x000407A8
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EBD RID: 24253
		private static readonly IntPtr NativeFieldInfoPtr__Occupant_k__BackingField;

		// Token: 0x04005EBE RID: 24254
		private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

		// Token: 0x04005EBF RID: 24255
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04005EC0 RID: 24256
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04005EC1 RID: 24257
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0;

		// Token: 0x04005EC2 RID: 24258
		private static readonly IntPtr NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0;

		// Token: 0x04005EC3 RID: 24259
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005EC4 RID: 24260
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0;

		// Token: 0x04005EC5 RID: 24261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
