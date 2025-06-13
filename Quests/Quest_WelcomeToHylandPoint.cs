using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D1 RID: 465
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x06002742 RID: 10050 RVA: 0x000EEAB8 File Offset: 0x000ECCB8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WelcomeToHylandPoint()
		{
			Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WelcomeToHylandPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr);
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReturnToRVQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReadMessagesQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "RV");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "Nelson");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMaxDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMinDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "onExplode");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "exploded");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "cameraLookTime");
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667726);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667727);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667728);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667729);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667730);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667731);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000EEC14 File Offset: 0x000ECE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120915, XrefRangeEnd = 120917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000EEC50 File Offset: 0x000ECE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120917, XrefRangeEnd = 120929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000EEC84 File Offset: 0x000ECE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120929, XrefRangeEnd = 120941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000EECB8 File Offset: 0x000ECEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120941, XrefRangeEnd = 120959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000EED10 File Offset: 0x000ECF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120959, XrefRangeEnd = 120963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WelcomeToHylandPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000EED4C File Offset: 0x000ECF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120963, XrefRangeEnd = 120967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000159F2 File Offset: 0x00013BF2
		public Quest_WelcomeToHylandPoint(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000EED80 File Offset: 0x000ECF80
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x000159FB File Offset: 0x00013BFB
		public unsafe QuestEntry ReturnToRVQuest
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000EEDB0 File Offset: 0x000ECFB0
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x00015A1A File Offset: 0x00013C1A
		public unsafe QuestEntry ReadMessagesQuest
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000EEDE0 File Offset: 0x000ECFE0
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x00015A39 File Offset: 0x00013C39
		public unsafe RV RV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000EEE10 File Offset: 0x000ED010
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00015A58 File Offset: 0x00013C58
		public unsafe UncleNelson Nelson
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000EEE40 File Offset: 0x000ED040
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00015A77 File Offset: 0x00013C77
		public unsafe float ExplosionMaxDist
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist)) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000EEE68 File Offset: 0x000ED068
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x00015A92 File Offset: 0x00013C92
		public unsafe float ExplosionMinDist
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist)) = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000EEE90 File Offset: 0x000ED090
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x00015AAD File Offset: 0x00013CAD
		public unsafe UnityEvent onExplode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000EEEC0 File Offset: 0x000ED0C0
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x00015ACC File Offset: 0x00013CCC
		public unsafe bool exploded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded)) = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000EEEE8 File Offset: 0x000ED0E8
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x00015AE7 File Offset: 0x00013CE7
		public unsafe float cameraLookTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime)) = value;
			}
		}

		// Token: 0x04001A1D RID: 6685
		private static readonly System.IntPtr NativeFieldInfoPtr_ReturnToRVQuest;

		// Token: 0x04001A1E RID: 6686
		private static readonly System.IntPtr NativeFieldInfoPtr_ReadMessagesQuest;

		// Token: 0x04001A1F RID: 6687
		private static readonly System.IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x04001A20 RID: 6688
		private static readonly System.IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x04001A21 RID: 6689
		private static readonly System.IntPtr NativeFieldInfoPtr_ExplosionMaxDist;

		// Token: 0x04001A22 RID: 6690
		private static readonly System.IntPtr NativeFieldInfoPtr_ExplosionMinDist;

		// Token: 0x04001A23 RID: 6691
		private static readonly System.IntPtr NativeFieldInfoPtr_onExplode;

		// Token: 0x04001A24 RID: 6692
		private static readonly System.IntPtr NativeFieldInfoPtr_exploded;

		// Token: 0x04001A25 RID: 6693
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraLookTime;

		// Token: 0x04001A26 RID: 6694
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly System.IntPtr NativeMethodInfoPtr_Explode_Public_Void_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x02000905 RID: 2309
		[ObfuscatedName("ScheduleOne.Quests.Quest_WelcomeToHylandPoint+<<Explode>g__Shake|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C88A RID: 51338 RVA: 0x003105CC File Offset: 0x0030E7CC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "<<Explode>g__Shake|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667732);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667733);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667734);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667735);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667736);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667737);
			}

			// Token: 0x0600C88B RID: 51339 RVA: 0x00310698 File Offset: 0x0030E898
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C88C RID: 51340 RVA: 0x003106E0 File Offset: 0x0030E8E0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C88D RID: 51341 RVA: 0x00310714 File Offset: 0x0030E914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120904, XrefRangeEnd = 120910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E50 RID: 15952
			// (get) Token: 0x0600C88E RID: 51342 RVA: 0x00310750 File Offset: 0x0030E950
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C88F RID: 51343 RVA: 0x00310790 File Offset: 0x0030E990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120910, XrefRangeEnd = 120915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E51 RID: 15953
			// (get) Token: 0x0600C890 RID: 51344 RVA: 0x003107C4 File Offset: 0x0030E9C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C891 RID: 51345 RVA: 0x000613D5 File Offset: 0x0005F5D5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E4E RID: 15950
			// (get) Token: 0x0600C892 RID: 51346 RVA: 0x00310804 File Offset: 0x0030EA04
			// (set) Token: 0x0600C893 RID: 51347 RVA: 0x000613DE File Offset: 0x0005F5DE
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E4F RID: 15951
			// (get) Token: 0x0600C894 RID: 51348 RVA: 0x0031082C File Offset: 0x0030EA2C
			// (set) Token: 0x0600C895 RID: 51349 RVA: 0x000613F9 File Offset: 0x0005F5F9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008806 RID: 34822
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008807 RID: 34823
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008808 RID: 34824
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008809 RID: 34825
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400880A RID: 34826
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400880B RID: 34827
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400880C RID: 34828
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400880D RID: 34829
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
